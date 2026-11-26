using System.ComponentModel.DataAnnotations;

namespace MyFirstWebAPI.Models;

public class Purchase
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int ProductId { get; set; }

    [Required]
    public int Quantity { get; set; }

    [Required]
    public decimal PurchasePrice { get; set; }

    public DateTime PurchaseDate { get; set; }
        = DateTime.UtcNow;

    public Product? Product { get; set; }
}