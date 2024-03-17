using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgresql.API.Models;

public class Product
{
    [Key, Required]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
