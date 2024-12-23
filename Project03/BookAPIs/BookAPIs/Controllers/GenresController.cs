using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAPIs.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookAPIs.Controllers
{
    public class GenresController:ControllerBase
    {
        private readonly AppDbContext _context;

        public GenresController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetGenres()
        {
            var genres = await _context.Genres.Include(g=>g.Books).ToListAsync();
            return Ok(genres);
        }
    }
}