using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Models;
public class Provider
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required(ErrorMessage = "Provider's name is a required field.")]
    public string? Name { get; set; }

    public ICollection<Order>? Orders { get; set; }
}