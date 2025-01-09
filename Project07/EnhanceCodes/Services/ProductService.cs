using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnhanceCodes.Models;

namespace EnhanceCodes.Services
{
    public class ProductService : IProductService
    {
         private readonly List<Product> _products;

         public ProductService(List<Product> products)
         {
            _products =new List<Product>
            {
                new Product{Id = 1, Name = "Laptop", Price = 1200};
                new Product{Id = 2, Name = "Smartphone", Price = 800};
            };
         }
        public Task<Product> CreateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateProductAsync(int id, Product updatedProduct)
        {
            throw new NotImplementedException();
        }
    }
}