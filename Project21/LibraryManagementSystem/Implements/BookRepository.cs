using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Implements
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDbContext _context;
        public Task AddBookAsync(Book book)
        {
            throw new NotImplementedException();
        }

        public Task<bool> BookExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBookAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBookByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetBooksByCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> SearchBooksAsync(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBookAsync(Book book)
        {
            throw new NotImplementedException();
        }
    }
}