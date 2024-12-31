using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoryPatternDemo.Interfaces;
using RepositoryPatternDemo.models;

namespace RepositoryPatternDemo.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public async Task AddProductAsync(string name, decimal price)
        {
            var product = new Product{Name=name, Price=price};
            await _repository.AddAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _repository.GetAllProduct();
        }

        public async Task UpdateProductAsync(int id, string name, decimal price)
        {
            var product = await _repository.GetByIdAsync(id);
            if(product !=null)
            {
                product.Name=name;
                product.Price=price;
                await _repository.UpdateAsync(product);
            }

        }
    }
}