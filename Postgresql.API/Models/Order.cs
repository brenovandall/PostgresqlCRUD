using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgresql.API.Models;

public class Order
{
    [Key, Required]
    public Guid Id { get; set; }
    public IEnumerable<Product>? Products { get; set; } = new List<Product>();
}
