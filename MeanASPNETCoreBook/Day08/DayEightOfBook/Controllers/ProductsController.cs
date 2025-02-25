using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DayEightOfBook.Data;
using DayEightOfBook.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DayEightOfBook.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/products")]
    public class ProductsController:ControllerBase
    {
        private readonly AppDbContext _context;        
        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            Console.WriteLine("Hello");
            return await _context.Products.ToListAsync();
        }

        [HttpGet("test")]
        [AllowAnonymous]
        public IActionResult Test()
        {
            Console.WriteLine("Test endpoint hit");
            return Ok("Test works!");
        }


        [Authorize(Roles ="Admin")]
        [HttpPost]
        public async Task<ActionResult<Product>> AddProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProducts), new {id= product.Id}, product);
        }
    }
}