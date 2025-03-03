using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;
using CachingwithRedis.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace CachingwithRedis.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController:ControllerBase
    {
        private readonly IMemoryCache _cache;
        public ProductController(IMemoryCache cache)
        {
            _cache = cache;   
        }

        [HttpGet("get-products")]
        public IActionResult GetProducts()
        {
            if(_cache.TryGetValue("products", out List<Product>? products))
            {
                products = new List<Product>
                {
                    new Product (1, "Laptop", 1200),
                    new Product(2, "Mobile", 800),
                };

                var cacheOption = new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(30)
                };

                _cache.Set("products", products, cacheOption);
            }

            return Ok(products);
        }
    }
}