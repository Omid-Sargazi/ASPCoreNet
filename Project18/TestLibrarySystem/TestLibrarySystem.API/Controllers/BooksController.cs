using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestLibrarySystem.API.Data;
using TestLibrarySystem.API.Models;

namespace TestLibrarySystem.API.Controllers
{
    public class BooksController:ControllerBase
    {
        private readonly LibraryDbContext _context;

        public BooksController(LibraryDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var books  = await _context.Books.ToListAsync();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            return book ==null ? NotFound() : Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] Book book)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBook), new{id= book.Id}, book);
        }
    }
}