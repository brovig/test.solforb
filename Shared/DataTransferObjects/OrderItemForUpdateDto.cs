using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects;
public record OrderItemForUpdateDto : OrderItemForManipulationDto 
{
    [Range(0, int.MaxValue, ErrorMessage = "Order item id is a required field.")]
    public int Id { get; init; }
}