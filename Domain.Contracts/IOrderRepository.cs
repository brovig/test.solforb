using Domain.Entities.Models;
using Shared.RequestFeatures;

namespace Domain.Contracts;
public interface IOrderRepository
{
    Task<PagedList<Order>> GetOrdersAsync(OrderParameters orderParameters, bool trackChanges);
    Task<Order> GetOrderByIdAsync(int id, bool trackChanges);
    Task<IEnumerable<Order>> GetOrdersForProviderAsync(int providerId, bool trackChanges);
    void CreateOrder(Order order);
    void DeleteOrder(Order order);
    void UpdateOrder(Order order);
}
