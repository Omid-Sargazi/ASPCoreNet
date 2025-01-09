using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestfulApiDemo.Models;

namespace RestfulApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController:ControllerBase
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1200 },
            new Product { Id = 2, Name = "Smartphone", Price = 800 },
            new Product { Id = 3, Name = "Headphones", Price = 150 }
        };


        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(products);
        }
    }
}