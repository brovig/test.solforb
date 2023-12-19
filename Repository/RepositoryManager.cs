using Domain.Contracts;

namespace Repository;
public sealed class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _context;
    private readonly Lazy<IOrderRepository> _orderRepository;
    private readonly Lazy<IOrderItemRepository> _orderItemRepository;
    private readonly Lazy<IProviderRepository> _providerRepository;

    public RepositoryManager(RepositoryContext context)
    {
        _context = context;
        _orderRepository = new Lazy<IOrderRepository>(() => new OrderRepository(context));
        _orderItemRepository = new Lazy<IOrderItemRepository>(() => new OrderItemRepository(context));
        _providerRepository = new Lazy<IProviderRepository>(() => new ProviderRepository(context));
    }

    public IOrderRepository Order => _orderRepository.Value;
    public IOrderItemRepository OrderItem => _orderItemRepository.Value;
    public IProviderRepository Provider => _providerRepository.Value;

    public async Task SaveAsync() => await _context.SaveChangesAsync();
}