namespace Domain.Contracts;
public interface IRepositoryManager
{
    IOrderRepository Order { get; }
    IOrderItemRepository OrderItem { get; }
    IProviderRepository Provider { get; }
    Task SaveAsync();
}
