using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoookAPIs2.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BoookAPIs2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorsController:ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthorsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAuthors()
        {
            var authors = await _context.Authors
            .Include(a => a.Books)
            .Select(a => new AuthorDto
            {
                Id = a.Id,
                Name = a.Name,
                BookTitles = a.Books.Select(b => b.Title).ToList()
            })
            .ToListAsync();

            return Ok(authors);
        }
    }
}