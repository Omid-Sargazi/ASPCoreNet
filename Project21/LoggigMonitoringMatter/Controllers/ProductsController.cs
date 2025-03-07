using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoggigMonitoringMatter.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoggigMonitoringMatter.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController:ControllerBase
    {
        private static List<Product> _products = new List<Product>
    {
        new Product { Id = 1, Name = "Laptop", Price = 999.99m, StockQuantity = 10 },
        new Product { Id = 2, Name = "Smartphone", Price = 499.99m, StockQuantity = 15 },
        new Product { Id = 3, Name = "Headphones", Price = 99.99m, StockQuantity = 20 }
    };

    [HttpGet("products")]
    public IActionResult GetAllProducts()
    {
        return Ok(_products);
    }

    [HttpGet("products/{id}")]
    public IActionResult GetProduct(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }

    [HttpPost("products")]
    public IActionResult CreateProduct(Product product)
    {
        product.Id = _products.Max(p => p.Id) + 1;
        _products.Add(product);
        return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
    }
    }
}