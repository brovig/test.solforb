using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects;
public abstract record OrderItemForManipulationDto
{
    [Required(ErrorMessage = "Order item name is a required field.")]
    public string? Name { get; init; }

    [Required(ErrorMessage = "Order item quantity is a required field.")]
    public decimal Quantity { get; init; }
    
    [Required(ErrorMessage = "Order item unit is a required field.")]
    public string? Unit { get; init; }
}