using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Models;
public class Order
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required(ErrorMessage = "Order number is a required field.")]
    public string? Number { get; set; }
    [Required(ErrorMessage = "Order date is a required field.")]
    public DateTime Date { get; set; }

    [Required(ErrorMessage = "Order's provider is a required field.")]
    public int ProviderId { get; set; }
    public Provider? Provider { get; set; }
    public ICollection<OrderItem>? Items { get; set; }
}
