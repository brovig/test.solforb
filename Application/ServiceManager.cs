using AutoMapper;
using Domain.Contracts;
using Service.Contracts;

namespace Service;
public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<IOrderService> _orderService;
    private readonly Lazy<IOrderItemService> _orderItemService;
    private readonly Lazy<IProviderService> _providerService;

    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
    {
        _orderService = new Lazy<IOrderService>(() => new OrderService(repositoryManager, logger, mapper));
        _orderItemService = new Lazy<IOrderItemService>(() => new OrderItemService(repositoryManager, logger, mapper));
        _providerService = new Lazy<IProviderService>(() => new ProviderService(repositoryManager, logger, mapper));
    }

    public IOrderService OrderService => _orderService.Value;
    public IOrderItemService OrderItemService => _orderItemService.Value;
    public IProviderService ProviderService => _providerService.Value;
}