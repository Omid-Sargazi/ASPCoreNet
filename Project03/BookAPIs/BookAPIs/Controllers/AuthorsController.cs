using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAPIs.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookAPIs.Controllers
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
            var authors = await _context.Authors.Include(a=>a.Books).ToListAsync();
            return Ok(authors);
        }
    }
}