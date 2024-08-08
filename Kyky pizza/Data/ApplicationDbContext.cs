using Kyky_pizza.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Kyky_pizza.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Product> Product { get; set; }
    public DbSet<Pizza> Pizza { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<FoodStuff> FoodStuff { get; set; }
    public DbSet<AddressHome> AddressHome { get; set; }

    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().UseTptMappingStrategy();
        base.OnModelCreating(modelBuilder);
    }
}