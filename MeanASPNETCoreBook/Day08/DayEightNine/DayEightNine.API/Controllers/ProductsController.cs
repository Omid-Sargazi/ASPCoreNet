using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DayEightNine.API.Data;
using DayEightNine.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DayEightNine.API.Controllers
{
    // [Authorize]
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
           var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value; // "9236df0d-c390-4a3a-8ff5-6fa961230ae5"
            var email = User.FindFirst(ClaimTypes.Email)?.Value;           // "ss@ss.com"
            Console.WriteLine($"User: {userId}, Email: {email}");
            return await _context.Products.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            return product is null ? NotFound("Product not found") : Ok(product);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<ActionResult<Product>> AddProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProduct), new {id = product.Id}, product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Product updatedProduct)
        {
            if(id != updatedProduct.Id) return BadRequest("ID mismatch");

            _context.Entry(updatedProduct).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
         public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product is null) return NotFound("Product not found");

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return NoContent();
         }

         [HttpGet("test")]
         [AllowAnonymous]
         public IActionResult Test()
         {
            Console.WriteLine("Test");
            return Ok("test is Ok");
         }
    }
}