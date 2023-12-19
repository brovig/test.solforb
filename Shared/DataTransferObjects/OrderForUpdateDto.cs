using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects;
public record OrderForUpdateDto : OrderForManipulationDto
{
    [Range(1, int.MaxValue, ErrorMessage = "Order id is a required field.")]
    public int Id { get; init; }

    public IEnumerable<OrderItemForUpdateDto>? Items { get; init; }
}
