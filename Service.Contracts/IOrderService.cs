using Shared.DataTransferObjects;
using Shared.RequestFeatures;

namespace Service.Contracts;
public interface IOrderService
{
    Task<(IEnumerable<OrderDto> orders, MetaData metaData)> GetOrdersAsync(OrderParameters orderParameters, bool trackChanges);
    Task<OrderDto> GetOrderAsync(int id, bool trackChanges);
    Task<OrderDto> CreateOrderAsync(OrderForCreationDto order);
    Task DeleteOrderAsync(int id, bool trackChanges);
    Task UpdateOrderAsync(int id, OrderForUpdateDto orderForUpdate, bool trackChanges);
}
