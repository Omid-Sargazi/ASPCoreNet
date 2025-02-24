using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeanASPNETCoreBook.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MeanASPNETCoreBook.API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsTwoController:ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsTwoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            return product is null ? NotFound("Product not found") : Ok(product);
        }

        public async Task<ActionResult<Product>> AddProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProduct), new {id = product.Id}, product);
        }


        [HttpPost("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Product updatedProduct)
        {
            if(id != updatedProduct.Id)
            {
                return BadRequest("ID mismatch");
            }

            _context.Entry(updatedProduct).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if(product == null) return NotFound("Product not found");

            _context.Products.Remove(product);
           await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}