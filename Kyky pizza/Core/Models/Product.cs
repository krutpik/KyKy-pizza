using System.ComponentModel.DataAnnotations.Schema;

namespace Kyky_pizza.Models;

public abstract class Product
{
    public int Id { get; set; }
    public string Category;
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Image { get; set; }
    public bool Availability { get; set; }
    public List<Order> Orders { get; } = [];


    protected Product()
    {
        Category = this.ToString();
    }
}