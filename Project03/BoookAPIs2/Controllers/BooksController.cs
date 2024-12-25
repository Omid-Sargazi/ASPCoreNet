using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoookAPIs2.DTOs;
using BoookAPIs2.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BoookAPIs2.Controllers
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
        public async Task<IActionResult> GetBooks()
        {
           var books = await _context.Books
            .Include(b => b.Author)
            .Include(b => b.Genre)
            .Select(b => new BookDto
            {
                Id = b.Id,
                Title = b.Title,
                AuthorName = b.Author.Name,
                GenreName = b.Genre.Name
            })
            .ToListAsync();

            return Ok(books);
        }


        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] Book book)
        {
            if(!_context.Authors.Any(a=>a.Id==book.AuthorId) || !_context.Genres.Any(g=>g.Id==book.GenreId))
            {
                return BadRequest("Invalid AuthorId or GenreId.");
            }

            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBooks), new { id = book.Id }, book);
        }
    }
}