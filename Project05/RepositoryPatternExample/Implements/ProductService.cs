using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoryPatternExample.Interfaces;
using RepositoryPatternExample.models;

namespace RepositoryPatternExample.Implements
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repositpry;

        public ProductService(IProductRepository repository)
        {
            _repositpry = repository;            
        }
        public async Task AddProductAsync(string Name, decimal Price)
        {
            var product = new Product{Name=Name, Price=Price};
            await _repositpry.AddAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            await _repositpry.DeleteAsync(id);
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _repositpry.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _repositpry.GetAllAsync();
        }

        public async Task UpdateProductAsync(int id, string name, decimal price)
        {
            var product = await _repositpry.GetByIdAsync(id);
            if(product !=null)
            {
                product.Name = name;
                product.Price = price;
                await _repositpry.UpdateAsync(product);
            }
        }
    }
}