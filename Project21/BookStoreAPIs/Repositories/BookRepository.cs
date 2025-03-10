using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreAPIs.Data;
using BookStoreAPIs.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreAPIs.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _context;

        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }
        public async Task<Book> AddBookAsync(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<bool> BookExistsAsync(int id)
        {
            return await _context.Books.AnyAsync(b=>b.Id == id);
        }

        public async Task DeleteBookAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if(book !=null)
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return await _context.Books
            .Include(b => b.Author).ToListAsync();
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _context.Books
            .Include(b => b.Author)
            .FirstOrDefaultAsync(b => b.Id ==id);
        }

        public async Task<IEnumerable<Book>> GetBooksByAuthorAsync(int authorId)
        {
            return await _context.Books
            .Include(b => b.Author)
            .Where(b => b.AuthorId == authorId)
            .ToListAsync();
        }

        public async Task<bool> ISBNExistsAsync(string isbn, int? excludeBookId = null)
        {
            return excludeBookId.HasValue ?
                await _context.Books.AnyAsync(b => b.ISBN== isbn && b.Id !=excludeBookId)
                :await _context.Books.AnyAsync(b => b.ISBN ==isbn);
        }

        public async Task UpdateBookAsync(Book book)
        {
            _context.Entry(book).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}