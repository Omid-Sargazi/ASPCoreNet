using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnhanceCodes.Models;
using Microsoft.AspNetCore.Identity;

namespace EnhanceCodes.Services
{
    public class ProductService : IProductService
    {
         private readonly List<Product> _products;

         public ProductService(List<Product> products)
         {
            _products =new List<Product>
            {
                new Product{Id = 1, Name = "Laptop", Price = 1200},
                new Product{Id = 2, Name = "Smartphone", Price = 800}
            };
         }
        public Task<Product> CreateProductAsync(Product product)
        {
            product.Id = _products.Max(p=>p.Id)+1;
            _products.Add(product);
            return Task.FromResult(product);
        }

        public Task<bool> DeleteProductAsync(int id)
        {
            var product = _products.FirstOrDefault(p=>p.Id==id);
            if(product==null) return Task.FromResult(false);
            
            _products.Remove(product);
            return Task.FromResult(true);
        }

        public Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return Task.FromResult(_products.AsEnumerable());
        }

        public Task<Product> GetProductByIdAsync(int id)
        {
            var product = _products.FirstOrDefault(p=>p.Id==id);
            return Task.FromResult(product);
        }

        public Task<Product> UpdateProductAsync(int id, Product updatedProduct)
        {
            var product = _products.FirstOrDefault(p=>p.Id==id);
            if(product == null) return Task.FromResult<Product>(null);

            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;
            return Task.FromResult(product);
        }
    }
}