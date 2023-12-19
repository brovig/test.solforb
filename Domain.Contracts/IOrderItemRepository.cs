using Domain.Entities.Models;

namespace Domain.Contracts;
public interface IOrderItemRepository
{
    Task<IEnumerable<OrderItem>> GetOrderItemsAsync(bool trackChanges);
    Task<IEnumerable<OrderItem>> GetItemsByOrderIdAsync(int orderId, bool trackChanges);
    Task<OrderItem> GetOrderItemAsync(int orderId, int id, bool trackChanges);
    Task<List<int>> GetOrderIdsByOrderItemParametersAsync(List<string> orderItemNames, List<string> orderItemUnits);
    void CreateOrderItem(int orderId, OrderItem orderItem);
    void DeleteOrderItem(OrderItem orderItem);
}