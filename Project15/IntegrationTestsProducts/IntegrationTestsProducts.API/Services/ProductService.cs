using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegrationTestsProducts.API.Data;
using IntegrationTestsProducts.API.Models;
using Microsoft.EntityFrameworkCore;

namespace IntegrationTestsProducts.API.Services
{
    public class ProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Product> CreateProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products.Include(p => p.Category).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.Products.Include(p => p.Category).ToListAsync();
        }


        public async Task<bool> DeleteProductAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if(product == null) return false;

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}