namespace Kyky_pizza.Models;

public class NutritionalValue
{
    public int Id { get; set; }
    //public int PositionId { get; set; }
    public Product Product { get; set; } = null!;
    public float? Calorie { get; set; }
    public float? Proteins { get; set; }
    public float? Fats { get; set; }
    public float? Carbohydrates { get; set; }
    public int Weight { get; set; }
}    