using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Models;
[Table("OrderItems")]
public class OrderItem
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }    
    [Required(ErrorMessage = "Item's name is a required field.")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "Item's quantity is a required field.")]
    [Column(TypeName = "decimal(18,3)")]
    public decimal Quantity { get; set; }
    public string? Unit {  get; set; }

    [Required(ErrorMessage = "Order ID is a required field.")]
    public int OrderId { get; set; }
    public Order? Order { get; set; }
}
