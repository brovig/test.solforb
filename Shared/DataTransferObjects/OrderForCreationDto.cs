namespace Shared.DataTransferObjects;
public record OrderForCreationDto : OrderForManipulationDto
{
    public IEnumerable<OrderItemForCreationDto>? Items { get; init; }
}