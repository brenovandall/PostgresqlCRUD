using Microsoft.EntityFrameworkCore;
using Postgresql.API.Models;

namespace Postgresql.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
}
