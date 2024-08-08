namespace Kyky_pizza.Models;

public class FoodStuff
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Availability { get; set; }
    public List<Pizza> Pizzas { get; } = [];

}