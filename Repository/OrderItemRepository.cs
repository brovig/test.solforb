using Domain.Contracts;
using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository;
internal sealed class OrderItemRepository : RepositoryBase<OrderItem>, IOrderItemRepository
{
    public OrderItemRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    // Get all order items (for all orders)
    public async Task<IEnumerable<OrderItem>> GetOrderItemsAsync(bool trackChanges)
    {
        var orderItems = await FindAll(trackChanges).ToListAsync();

        return orderItems;
    }

    // Get items for specific order
    public async Task<IEnumerable<OrderItem>> GetItemsByOrderIdAsync(int orderId, bool trackChanges)
    {
        var orderItems = await FindByCondition(oi => oi.OrderId.Equals(orderId), trackChanges).ToListAsync();

        return orderItems;
    }

    public async Task<OrderItem> GetOrderItemAsync(int orderId, int id, bool trackChanges)
    {
        var orderItem = await FindByCondition(oi => oi.OrderId.Equals(orderId) &&  oi.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

        return orderItem!;
    }

    public async Task<List<int>> GetOrderIdsByOrderItemParametersAsync(List<string> orderItemNames, List<string> orderItemUnits)
    {
        var query = FindAll(trackChanges: false);
        if (orderItemNames.Count > 0)
            query = query.Where(oi => orderItemNames.Contains(oi.Name!));
        if (orderItemUnits.Count > 0)
            query = query.Where(oi => orderItemUnits.Contains(oi.Unit!));

        var orderIds = await query.Select(orderItem => orderItem.OrderId).ToListAsync();

        return orderIds;
    }

    public void CreateOrderItem(int orderId, OrderItem orderItem)
    {
        orderItem.OrderId = orderId;
        Create(orderItem);
    }

    public void DeleteOrderItem(OrderItem orderItem)
    {
        Delete(orderItem);
    }
}