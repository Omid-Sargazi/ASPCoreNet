using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagement.Application.Interfaces;
using BookstoreManagement.Domain.Entities;
using BookstoreManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task AddAsync(Category author)
        {
            await _applicationDbContext.Categories.AddAsync(author);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var category = await GetByIdAsync(id);
            if(category != null)
            {
                _applicationDbContext.Categories.Remove(category);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Category>> GetAllAsync()
        {
            return await _applicationDbContext.Categories.ToListAsync();
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            var category = await _applicationDbContext.Categories.FindAsync(id);
            if(category == null)
                throw new KeyNotFoundException($"Category with ID {id} was not found.");
            
            return category;
        }

        public async Task UpdateAsync(Category category)
        {
            _applicationDbContext.Categories.Update(category);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}