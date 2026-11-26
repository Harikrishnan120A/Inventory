using Microsoft.EntityFrameworkCore;
using MyFirstWebAPI.Models;

namespace MyFirstWebAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(
        DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Purchase> Purchases { get; set; }

    public DbSet<Sale> Sales { get; set; }

    public DbSet<InventoryRecord> InventoryRecords
    {
        get;
        set;
    }
}