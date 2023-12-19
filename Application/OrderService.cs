using AutoMapper;
using Domain.Contracts;
using Domain.Entities.Exceptions;
using Domain.Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;
using Shared.RequestFeatures;

namespace Service;
internal sealed class OrderService : IOrderService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public OrderService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public async Task<(IEnumerable<OrderDto> orders, MetaData metaData)> GetOrdersAsync(OrderParameters orderParameters, bool trackChanges)
    {
        if (!orderParameters.ValidDateRange)
            throw new DateRangeBadRequestException();

        await ModifyOrderParameters(orderParameters);

        var ordersWithMetaData = await _repository.Order.GetOrdersAsync(orderParameters, trackChanges);
        var ordersDto = _mapper.Map<IEnumerable<OrderDto>>(ordersWithMetaData);

        return (orders: ordersDto, metaData: ordersWithMetaData.MetaData);
    }

    public async Task<OrderDto> GetOrderAsync(int id, bool trackChanges)
    {
        var order = await GetOrderAndCheckIfExists(id, trackChanges);
        var orderDto = _mapper.Map<OrderDto>(order);

        return orderDto;
    }

    public async Task<OrderDto> CreateOrderAsync(OrderForCreationDto order)
    {
        await CheckOrderNumberForCorrectnessAsync(order.Number!, order.ProviderId);
        if (order.Items is not null)
        {
            foreach (var item in order.Items)
            {
                if (item.Name == order.Number)
                {
                    throw new OrderItemNameBadRequestException(order.Number!);
                }
            }
        }

        var orderEntity = _mapper.Map<Order>(order);

        _repository.Order.CreateOrder(orderEntity);
        await _repository.SaveAsync();

        var orderToReturn = _mapper.Map<OrderDto>(orderEntity);

        return orderToReturn;
    }

    public async Task DeleteOrderAsync(int id, bool trackChanges)
    {
        var order = await GetOrderAndCheckIfExists(id, trackChanges);

        _repository.Order.DeleteOrder(order);
        await _repository.SaveAsync();
    }

    public async Task UpdateOrderAsync(int id, OrderForUpdateDto orderForUpdate, bool trackChanges)
    {
        if (orderForUpdate.Items is not null)
        {
            foreach (var item in orderForUpdate.Items)
            {
                if (item.Name == orderForUpdate.Number)
                {
                    throw new OrderItemNameBadRequestException(orderForUpdate.Number!);
                }
            }
        }

        var orderDb = await GetOrderAndCheckIfExists(id, trackChanges);

        await CheckOrderNumberForCorrectnessAsync(orderForUpdate.Number!, orderForUpdate.ProviderId, id);

        _mapper.Map(orderForUpdate, orderDb);
        _repository.Order.UpdateOrder(orderDb);

        if (orderForUpdate.Items is not null)
            ProcessOrderItems(orderForUpdate, orderDb);

        await _repository.SaveAsync();
    }


    // helper methods
    private async Task<Order> GetOrderAndCheckIfExists(int id, bool trackChanges)
    {
        var order = await _repository.Order.GetOrderByIdAsync(id, trackChanges);
        if (order is null)
            throw new OrderNotFoundException(id);

        return order;
    }

    private async Task CheckOrderNumberForCorrectnessAsync(string number, int providerId, int id = 0)
    {
        var orders = await _repository.Order.GetOrdersForProviderAsync(providerId, trackChanges: false);
        if (orders is null) return;

        var orderWithNumber = orders.Where(o => o.Number!.Equals(number)).SingleOrDefault();
        if (orderWithNumber is null) return;

        if (id == 0 || orderWithNumber.Id != id)
            throw new OrderNumberBadRequestException(number, providerId);
    }

    // Transform filter parameters related to OrderItem (name, unit) and Provider (name) to Order properties
    // (order id, provider id) for further GetOrders query simplification
    private async Task ModifyOrderParameters(OrderParameters orderParameters)
    {
        if (orderParameters.OrderItemNames.Count > 0 || orderParameters.OrderItemUnits.Count > 0)
        {
            var orderIds = await _repository.OrderItem.GetOrderIdsByOrderItemParametersAsync(orderParameters.OrderItemNames, orderParameters.OrderItemUnits);
            orderParameters.OrderIds.AddRange(orderIds);
        }

        if (orderParameters.ProviderNames.Count > 0)
        {
            var additionalProviderIds = await _repository.Provider.GetProviderIdsByProviderNames(orderParameters.ProviderNames);
            orderParameters.ProviderIds.AddRange(additionalProviderIds);
        }
    }

    private void ProcessOrderItems(OrderForUpdateDto orderDto, Order order)
    {
        foreach (var orderItemDto in orderDto.Items!)
        {
            if (orderItemDto.Id == 0)
            {
                var orderToAdd = _mapper.Map<OrderItem>(orderItemDto);
                orderToAdd.OrderId = order.Id;
                order.Items!.Add(orderToAdd);
                _repository.OrderItem.CreateOrderItem(order.Id, orderToAdd);
            }
            else
            {
                _mapper.Map(orderItemDto, order.Items!.SingleOrDefault(oi => oi.Id == orderItemDto.Id));
            }
        }

        foreach (var orderItem in order.Items!)
        {
            bool isInListForUpdate = orderDto.Items.Any(oi => oi.Id == orderItem.Id);

            if (!isInListForUpdate)
            {
                order.Items.Remove(orderItem);
                _repository.OrderItem.DeleteOrderItem(orderItem);
            }
        }
    }
}