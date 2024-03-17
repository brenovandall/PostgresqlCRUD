using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Postgresql.API.Models;
using Postgresql.API.Repositories;

namespace Postgresql.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _repository;
    public ProductController(IProductRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<IReadOnlyList<Product>> GetProductsAsync()
    {
        return _repository.GetAllProducts();
    }

    [HttpGet("get/{id}")]
    public async Task<Product> GetProductById(Guid id)
    {
        return _repository.GetProductById(id);
    }

    [HttpPost("create")]
    public async Task<Product> CreateProduct(Product product)
    {
        return _repository.CreateProduct(product);
    }

    [HttpPut("edit/{id}")]
    public async Task<Product> UpdateProduct(string name, decimal price, Guid id)
    {
        return _repository.UpdateProduct(name, price, id);
    }

    [HttpDelete("delete/product")]
    public async Task<IActionResult> DeleteProduct(Guid id)
    {
        _repository.DeleteProduct(id);

        return Ok();
    }
}
