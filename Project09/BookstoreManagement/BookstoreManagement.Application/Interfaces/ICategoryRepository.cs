using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagement.Domain.Entities;

namespace BookstoreManagement.Application.Interfaces
{
    public interface ICategoryRepository
    {
        Task<Category> GetByIdAsync(int id);
        Task AddAsync(Category author);
        Task UpdateAsync(Category author);
        Task DeleteAsync(int id);
        Task<List<Category>> GetAllAsync();
    }
}