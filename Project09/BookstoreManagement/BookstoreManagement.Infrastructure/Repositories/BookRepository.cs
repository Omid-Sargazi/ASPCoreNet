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
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _repository;

        public BookRepository(ApplicationDbContext repository)
        {
            _repository = repository;
        }
        public async Task AddAsync(Book book)
        {
            await _repository.Books.AddAsync(book);
            await _repository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var book = await GetByIdAsync(id);
            if(book !=null)
            {
                _repository.Books.Remove(book);
                await _repository.SaveChangesAsync();
            }
        }

        public async Task<List<Book>> GetAllAsync()
        {
            return await _repository.Books.Include(b=>b.Author).Include(b=>b.Category)
            .Include(b=>b.Inventory)
            .ToListAsync();
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            return await _repository.Books.Include(b=>b.Author)
            .Include(b=>b.Category).FirstOrDefaultAsync(b=>b.Id==id);
        }

        public async Task UpdateAsync(Book book)
        {
            _repository.Books.Update(book);
            await _repository.SaveChangesAsync();
        }
    }
}