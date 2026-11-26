using System.ComponentModel.DataAnnotations;

namespace MyFirstWebAPI.Models;

public class Sale
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int ProductId { get; set; }

    [Required]
    public int Quantity { get; set; }

    [Required]
    public decimal SalePrice { get; set; }

    public DateTime SaleDate { get; set; }
        = DateTime.UtcNow;

    public Product? Product { get; set; }
}