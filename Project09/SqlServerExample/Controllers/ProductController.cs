using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SqlServerExample.Data;

namespace SqlServerExample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController:ControllerBase
    {
        private readonly AppDbContext _context;
        
        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _context.Products.ToList();
            return Ok(products);    
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetProducts), new {id =product.Id}, product);
        }
    }
}