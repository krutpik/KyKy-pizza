using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace Kyky_pizza.Models;

public class AddressHome
{
    public int Id { get; set; }
    public string AddressName { get; set; }
    public User User { get; set; }
    public ICollection<Order> Orders { get; } = new List<Order>();

}