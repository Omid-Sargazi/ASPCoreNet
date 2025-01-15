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
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public AuthorRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task AddAsync(Author author)
        {
            await _applicationDbContext.Authors.AddAsync(author);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var author = await GetByIdAsync(id);
            if(author !=null)
            {
                _applicationDbContext.Authors.Remove(author);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Author>> GetAllAsync()
        {
            return await _applicationDbContext.Authors
            .Include(a => a.Books)
            .ToListAsync();
        }

        public async Task<Author> GetByIdAsync(int id)
        {
            return await _applicationDbContext.Authors.FindAsync(id);
        }

        public async Task UpdateAsync(Author author)
        {
            _applicationDbContext.Authors.Update(author);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}