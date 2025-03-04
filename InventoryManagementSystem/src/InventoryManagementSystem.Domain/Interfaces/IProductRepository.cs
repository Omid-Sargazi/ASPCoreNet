using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using InventoryManagementSystem.Domain.Exceptions;

namespace InventoryManagementSystem.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int id);
        Task<IReadOnlyList<Product>> ListAllAsync();
        Task<IReadOnlyList<Product>> ListAsync(Expression<Func<Product, bool>> predict);
        Task<Product> AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(Product product);
        Task<IReadOnlyList<Product>> GetProductByCategoryAsync(int categoryId);
        Task<IReadOnlyList<Product>> GetLowStockProducts(int threshold);
        Task<IReadOnlyList<Product>> FindBySpecificationAsync(ISpecification<Product> specification);
    }
}