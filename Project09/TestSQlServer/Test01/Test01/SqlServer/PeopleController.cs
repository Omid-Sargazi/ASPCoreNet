using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Test01.SqlServer
{
     [ApiController]
    [Route("api/[controller]")]
    public class PeopleController:ControllerBase
    {
         private readonly AppDbContext _context;

        public PeopleController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.People.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Person person)
        {
            _context.People.Add(person);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = person.Id }, person);
        }
    }
    
}