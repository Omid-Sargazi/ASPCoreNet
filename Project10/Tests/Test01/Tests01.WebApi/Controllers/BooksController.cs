using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tests01.Domain.Data;
using Tests01.Domain.Models;

namespace Tests01.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetBooks()
        {
            return await _context.Books.Include(b => b.Author).ToListAsync();
        } 
    }
}