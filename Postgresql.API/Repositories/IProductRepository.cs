using Postgresql.API.Models;
using System.Collections.Specialized;

namespace Postgresql.API.Repositories;

public interface IProductRepository
{
    public IReadOnlyList<Product> GetAllProducts();
    public Product GetProductById(Guid id);
    public Product CreateProduct(Product product);
    public Product UpdateProduct(string name, decimal price, Guid id);
    public void DeleteProduct(Guid id);
}
