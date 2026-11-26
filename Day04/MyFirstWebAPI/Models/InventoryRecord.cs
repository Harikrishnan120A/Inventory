using System.ComponentModel.DataAnnotations;

namespace MyFirstWebAPI.Models;

public class InventoryRecord
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int ProductId { get; set; }

    [Required]
    public int QuantityChanged { get; set; }

    [Required]
    [MaxLength(50)]
    public string TransactionType { get; set; }
        = string.Empty;

    public DateTime RecordedAt { get; set; }
        = DateTime.UtcNow;

    [MaxLength(250)]
    public string? Notes { get; set; }

    public Product? Product { get; set; }
}