namespace Service.Contracts;
public interface IServiceManager
{
    IOrderService OrderService { get; }
    IOrderItemService OrderItemService { get; }
    IProviderService ProviderService { get; }
}
