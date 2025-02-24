using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MeanASPNETCoreBook.API.Controllers
{
    [ApiController]
   [Route("api/v{version:apiVersion}/products")]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class ProductsController:ControllerBase
    {
        private static readonly List<Product> products = new()
        {
            new Product(1,"Laptop", 1522),
            new Product(2,"Laptop", 1522),
        };

        // [HttpGet]
        // public ActionResult<IEnumerable<Product>> GetProducts() => Ok(products);

        // [HttpGet("{id:int}")]
        // public ActionResult<Product> GetProduct(int id)
        // {
        //     var product = products.FirstOrDefault(p => p.Id == id);
        //     return product is null ? NotFound("product not found.") : Ok(product);
        // }

        // [HttpPost]
        // public ActionResult<Product> AddProduct(Product product)
        // {
        //     products.Add(product);
        //     return CreatedAtAction(nameof(GetProduct), new {id = product.Id}, product);
        // }

        [HttpGet, MapToApiVersion("1.0")]
        public ActionResult<IEnumerable<Product>> GetV1() => Ok(products);

        [HttpGet, MapToApiVersion("2.0")]
        public ActionResult<IEnumerable<Product>> GetV2([FromQuery] string? name)
        {
            var filtered = string.IsNullOrEmpty(name) ? products : products.Where(p => p.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
            return Ok(filtered);
        }

    }


    public record Product(int Id, string Name, decimal Price);
}