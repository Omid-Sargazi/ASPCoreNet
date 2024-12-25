using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoookAPIs2.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace BoookAPIs2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
            var genres = await _context.Genres.Include(g=>g.Books).Select(g=> new GenreDto{
                Id=g.Id,
                Name=g.Name,
                BookTitles = g.Books.Select(b=>b.Title).ToList()
            }).ToListAsync();

            return Ok(genres);
        }
    }
}