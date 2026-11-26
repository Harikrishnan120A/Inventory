using System.ComponentModel.DataAnnotations;

namespace MyFirstWebAPI.Models;

public class Product
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(250)]
    public string? Description { get; set; }

    [Required]
    public decimal Price { get; set; }

    public int Stock { get; set; }

    public int CategoryId { get; set; }

    public Category? Category { get; set; }
}