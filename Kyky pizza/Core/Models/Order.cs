namespace Kyky_pizza.Models;

public enum OrderStatus
{
    Adopted,
    Preparing,
    Goes,
    Ready,
}

public class Order
{
    public int Id { get; set; }
    public User User { get; set; }
    public DateTime DateCreation { get; set; }
    public DateTime CompletionDate { get; set; }
    public OrderStatus Status { get; set; }
    public AddressHome AddressHome { get; set; }
    public List<Product> Products { get; } = [];

}