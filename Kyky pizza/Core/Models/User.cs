using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Kyky_pizza.Models;

public class User : IdentityUser
{
    public string? FirstName { get; set; }
    [DataType(DataType.Date)]
    public DateTime? Age { get; set; }
    public ICollection<AddressHome> AddressHomes { get; } = new List<AddressHome>();

}