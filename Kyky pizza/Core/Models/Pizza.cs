using System.ComponentModel.DataAnnotations.Schema;

namespace Kyky_pizza.Models;

public enum PizzaSize
{
    Small,
    Medium,
    Max
}

public enum PizzaTypeDough
{
    thin,
    classic
}

public class Pizza : Product
{
    public PizzaSize Size { get; set; }
    public PizzaTypeDough TypeDough { get; set; }
    public NutritionalValue NutritionalValue { get; set; }
    public List<FoodStuff> FoodStuffs { get; } = [];

}

