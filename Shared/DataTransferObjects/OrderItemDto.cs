namespace Shared.DataTransferObjects;
public record OrderItemDto(int Id, int OrderId, string Name, decimal Quantity, string Unit);
