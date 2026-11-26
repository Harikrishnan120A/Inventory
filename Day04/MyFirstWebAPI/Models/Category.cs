using System.ComponentModel.DataAnnotations;

namespace MyFirstWebAPI.Models;

public class Category
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(250)]
    public string? Description { get; set; }

    public List<Product> Products { get; set; } = new();
}