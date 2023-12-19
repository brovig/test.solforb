using Domain.Contracts;
using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Shared.RequestFeatures;

namespace Repository;
internal sealed class OrderRepository : RepositoryBase<Order>, IOrderRepository
{
    public OrderRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public async Task<PagedList<Order>> GetOrdersAsync(OrderParameters orderParameters, bool trackChanges)
    {
        var query = FindByCondition(o => o.Date >= orderParameters.StartDate && o.Date <= orderParameters.EndDate,
            trackChanges: trackChanges);

        if (orderParameters.OrderIds.Count > 0)
            query = query.Where(o => orderParameters.OrderIds.Contains(o.Id));

        if (orderParameters.OrderNumbers.Count > 0)
            query = query.Where(o => orderParameters.OrderNumbers.Contains(o.Number!));

        if (orderParameters.ProviderIds.Count > 0)
            query = query.Where(o => orderParameters.ProviderIds.Contains(o.ProviderId));

        var orders = await query
            .Select(o => new Order
            {
                Id = o.Id,
                Date = o.Date,
                Number = o.Number,
                ProviderId = o.ProviderId,
                Items = o.Items,
            })
            .Skip((orderParameters.PageNumber - 1) * orderParameters.PageSize)
            .Take(orderParameters.PageSize)
            .ToListAsync();

        var count = await query.CountAsync();

        return new PagedList<Order>(orders, count, orderParameters.PageNumber, orderParameters.PageSize);
    }
    
    public async Task<Order> GetOrderByIdAsync(int id, bool trackChanges)
    {
        var order = await FindByCondition(o => o.Id.Equals(id), trackChanges)
            .Select(o => new Order
            {
                Id = o.Id,
                Date = o.Date,
                Number = o.Number,
                ProviderId = o.ProviderId,
                Items = o.Items,
            })
            .SingleOrDefaultAsync();

        return order!;
    }

    public async Task<IEnumerable<Order>> GetOrdersForProviderAsync(int providerId, bool trackChanges)
    {
        var orders = await FindByCondition(o => o.ProviderId.Equals(providerId), trackChanges)
            .ToListAsync();

        return orders;
    }

    public void CreateOrder(Order order)
    {
        Create(order);
    }

    public void DeleteOrder(Order order)
    {
        Delete(order);
    }

    public void UpdateOrder(Order order)
    {
        Update(order);
    }
}
