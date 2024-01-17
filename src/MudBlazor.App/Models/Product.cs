using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My.Models;

public class Product
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = null!;

    [Required]
    [Column(TypeName = "decimal(6, 2)")]
    public decimal Price { get; set; }

    
    public ICollection<Order> Orders { get; set; } = null!;
    public ICollection<OrderDetail> OrderDetails { get; set; } = null!;
}