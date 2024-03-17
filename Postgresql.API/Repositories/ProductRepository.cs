using Postgresql.API.Data;
using Postgresql.API.Models;
using System.Security.Cryptography.Xml;

namespace Postgresql.API.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;
    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }
    public Product CreateProduct(Product product)
    {
        if(product == null) throw new Exception();

        _context.Products.AddAsync(product);
        _context.SaveChanges();

        return product;
    }

    public void DeleteProduct(Guid id)
    {
        var productToDelete = _context.Products.FirstOrDefault(x => x.Id == id);

        _context.Products.Remove(productToDelete);
        _context.SaveChanges();
    }

    public IReadOnlyList<Product> GetAllProducts()
    {
        return _context.Products.ToList();
    }

    public Product GetProductById(Guid id)
    {
        return _context.Products.FirstOrDefault(x => x.Id == id);
    }

    public Product UpdateProduct(string name, decimal price, Guid id)
    {
        var productToUpdate = _context.Products.FirstOrDefault(x => x.Id == id);

        if(productToUpdate != null)
        {
            productToUpdate.Name = name;
            productToUpdate.Price = price;
        }

        _context.SaveChanges();

        return productToUpdate;
    }
}
