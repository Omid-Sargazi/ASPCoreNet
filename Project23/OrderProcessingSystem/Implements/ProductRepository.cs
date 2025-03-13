using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderProcessingSystem.Data;
using OrderProcessingSystem.Interfacses;
using OrderProcessingSystem.Models;

namespace OrderProcessingSystem.Implements
{
    public class ProductRepository : IProductRepository
    {
        private readonly ECommerceDbContext _dbContext;
        public ProductRepository(ECommerceDbContext dbContext)
        {
            _dbContext = dbContext;   
        }
        public async Task<Product> GetByIdAsync(int id)
        {
            return await _dbContext.Products.FindAsync(id);
        }

        public async Task<List<Product>> GetByIdsAsync(List<int> ids)
        {
            return await _dbContext.Products.Where(p => ids.Contains(p.Id)).ToListAsync();
        }

        public async Task UpdateStockAsync(int productId, int quantity)
        {
            var product = await _dbContext.Products.FindAsync(productId);
            if(product !=null)
            {
                product.StockQuantity -= quantity;
                await _dbContext.SaveChangesAsync();

            }
        }
    }
}