using AutoMapper;
using Domain.Contracts;
using Domain.Entities.Exceptions;
using Domain.Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service;
internal sealed class OrderItemService : IOrderItemService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public OrderItemService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public async Task<IEnumerable<OrderItemDto>> GetOrderItemsAsync(int orderId, bool trackChanges)
    {
        await CheckIfOrderExists(orderId, trackChanges);

        var orderItems = await _repository.OrderItem.GetItemsByOrderIdAsync(orderId, trackChanges: false);
        var orderItemsDto = _mapper.Map<IEnumerable<OrderItemDto>>(orderItems);

        return orderItemsDto;
    }

    public async Task<OrderItemDto> GetOrderItemAsync(int orderId, int id, bool trackChanges)
    {
        await CheckIfOrderExists(orderId, trackChanges);

        var orderItem = await _repository.OrderItem.GetOrderItemAsync(orderId, id, trackChanges);
        var orderItemDto = _mapper.Map<OrderItemDto>(orderItem);

        return orderItemDto;
    }

    public async Task<OrderItemDto> CreateOrderItemAsync(int orderId, OrderItemForCreationDto orderItemForCreation, bool trackChanges)
    {
        string orderNumber = await CheckIfOrderExistsAndGetItsNumber(orderId, trackChanges);
        if (orderItemForCreation.Name == orderNumber)
            throw new OrderItemNameBadRequestException(orderNumber);

        var orderItemEntity = _mapper.Map<OrderItem>(orderItemForCreation);

        _repository.OrderItem.CreateOrderItem(orderId, orderItemEntity);
        await _repository.SaveAsync();

        var orderItemToReturn = _mapper.Map<OrderItemDto>(orderItemEntity);
        
        return orderItemToReturn;
    }

    public async Task DeleteOrderItemAsync(int orderId, int id, bool trackChanges)
    {
        await CheckIfOrderExists(orderId, trackChanges);

        var orderItem = await GetOrderItemAndCheckIfItExists(orderId, id, trackChanges);

        _repository.OrderItem.DeleteOrderItem(orderItem);
        await _repository.SaveAsync();
    }

    public async Task UpdateOrderItemAsync(int orderId, int id, OrderItemForUpdateDto orderItemForUpdate, bool orderTrackChanges, bool orderItemTrackChanges)
    {
        string orderNumber = await CheckIfOrderExistsAndGetItsNumber(orderId, orderTrackChanges);
        if (orderItemForUpdate.Name == orderNumber)
            throw new OrderItemNameBadRequestException(orderNumber);

        var orderItemDb = await GetOrderItemAndCheckIfItExists(orderId, id, orderItemTrackChanges);

        _mapper.Map(orderItemForUpdate, orderItemDb);
        await _repository.SaveAsync();
    }


    // helper methods
    private async Task CheckIfOrderExists(int id, bool trackChanges)
    {
        var order = await _repository.Order.GetOrderByIdAsync(id, trackChanges);
        if (order == null)
            throw new OrderNotFoundException(id);
    }

    private async Task<string> CheckIfOrderExistsAndGetItsNumber(int id, bool trackChanges)
    {
        var order = await _repository.Order.GetOrderByIdAsync(id, trackChanges);
        if (order == null)
            throw new OrderNotFoundException(id);

        return order.Number!;
    }

    private async Task<OrderItem> GetOrderItemAndCheckIfItExists(int orderId, int id, bool trackChanges)
    {
        var orderItem = await _repository.OrderItem.GetOrderItemAsync(orderId, id, trackChanges);
        if (orderItem is null)
            throw new OrderItemNotFoundException(id);

        return orderItem;
    }
}
