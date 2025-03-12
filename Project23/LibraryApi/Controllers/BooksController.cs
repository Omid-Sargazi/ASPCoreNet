using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApi.Data;
using LibraryApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController:ControllerBase
    {
        private readonly AppDbContext _context;

        public BooksController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            return await _context.Books
            .Include(b => b.Reviews)
            .Include(b => b.Categories).ToListAsync();

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> Getbook(int id)
        {
            var book = await _context.Books
            .Include(b => b.Reviews)
            .Include(b => b.Categories)
            .FirstOrDefaultAsync(b =>b.BookId == id);

            if(book == null)
            {
                return NotFound();
            }

            return book;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, Book book)
    {
        if (id != book.BookId) return BadRequest();

        _context.Entry(book).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Books.Any(b => b.BookId == id)) return NotFound();
            throw;
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBook(int id)
    {
        var book = await _context.Books.FindAsync(id);
        if (book == null) return NotFound();

        _context.Books.Remove(book);
        await _context.SaveChangesAsync();

        return NoContent();
    }
    }
}