using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegrationTestDemo.Data;
using IntegrationTestDemo.Services;

namespace IntegrationTestDemo.Implements
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
           return await Task.FromResult(_context.Products.ToList());
        }
    }
}