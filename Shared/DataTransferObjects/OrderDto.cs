namespace Shared.DataTransferObjects;
public record OrderDto(int Id, string Number, DateTime Date, int ProviderId, List<OrderItemDto> Items);
