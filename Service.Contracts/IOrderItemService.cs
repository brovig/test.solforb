using Shared.DataTransferObjects;

namespace Service.Contracts;
public interface IOrderItemService
{
    Task<IEnumerable<OrderItemDto>> GetOrderItemsAsync(int orderId, bool trackChanges);
    Task<OrderItemDto> GetOrderItemAsync(int orderId, int id, bool trackChanges);
    Task<OrderItemDto> CreateOrderItemAsync(int orderId, OrderItemForCreationDto orderItemForCreation, bool trackChanges);
    Task DeleteOrderItemAsync(int orderId, int id, bool trackChanges);
    Task UpdateOrderItemAsync(int orderId, int id, OrderItemForUpdateDto orderItemForUpdate, bool orderTrackChanges, bool orderItemTrackChanges);
}