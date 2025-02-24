using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MeanASPNETCoreBook.API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController:ControllerBase
    {
        private static readonly List<Product> products = new()
        {
            new Product(1,"Laptop", 1522),
            new Product(2,"Laptop", 1522),
        };

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts() => Ok(products);

        [HttpGet("{id:int}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            return product is null ? NotFound("product not found.") : Ok(product);
        }

        [HttpPost]
        public ActionResult<Product> AddProduct(Product product)
        {
            products.Add(product);
            return CreatedAtAction(nameof(GetProduct), new {id = product.Id}, product);
        }

    }


    public record Product(int Id, string Name, decimal Price);
}