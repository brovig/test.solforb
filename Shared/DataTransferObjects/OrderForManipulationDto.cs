using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects;
public abstract record OrderForManipulationDto
{
    [Required(ErrorMessage = "Order number is a required field.")]
    public string? Number { get; init; }

    [Required(ErrorMessage = "Order date is a required field.")]
    public DateTime Date { get; init; }

    [Range(1, int.MaxValue, ErrorMessage = "Order provider id is a required field.")]
    public int ProviderId { get; init; }
}
