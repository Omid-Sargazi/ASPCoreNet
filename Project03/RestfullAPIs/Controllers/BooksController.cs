using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestfullAPIs.Models;


//     [ApiController]
//     [Route("api/[controller]")]
//     public class BooksController:ControllerBase
//     {
//         private static List<Book> Books = new List<Book>
//         {
//             new Book{Id=1,Title="C# Basics",Author = "John Doe"},
//             new Book{Id = 2, Title = "ASP.NET Core", Author = "Jane Smith"}
//         };


//         [HttpGet("{id}")]
//         public IActionResult GetBook(int id)
//         {
//             var book = Books.FirstOrDefault(b=>b.Id==id);
//             if(book==null)
//             {
//                 return NotFound();
//             }
//             return Ok(book);
//         }

//         [HttpGet]
//         public IActionResult GetBooks()
//         {
//             return Ok(Books);
//         }
//         [HttpPost]
//         public IActionResult CreateBook([FromBody] Book newBook)
//         {
//             newBook.Id = Books.Max(b=>b.Id)+1;
//             Books.Add(newBook);

//             return CreatedAtAction(nameof(GetBook),new {id=newBook.Id},newBook);
//         }


//         [HttpDelete("{id}")]
//         public IActionResult DeleteBook(int id)
//         {
//             var book = Books.FirstOrDefault(b=>b.Id==id);
//             if(book==null)
//             {
//                 return NotFound();
//             }

//             Books.Remove(book);
//             return NoContent();
//         }
//     }





//     public class Book
// {
//     public int Id { get; set; }
//     public string Title { get; set; }
//     public string Author { get; set; }
// }


// [ApiController]
// [Route("api/[controller]")]
// public class BooksController:ControllerBase
// {
//     private readonly AppDbContext _context;

//     public BooksController(AppDbContext context)
//     {
//         _context = context;
//     }

//     [HttpGet]
//     public async Task<IActionResult> GetBooks()
//     {
//         var books = await _context.Books.ToListAsync();
//         return Ok(books);
//     }

//     [HttpPost]
//     public async Task<IActionResult> CreateBook([FromBody] Book newBook)
//     {
//         _context.Books.Add(newBook);
//         await _context.SaveChangesAsync();
//         return CreatedAtAction(nameof(GetBooks),new {id=newBook.Id},newBook);
//     }
// }


namespace RestfullAPIs.Controllers
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

    // GET: api/authors/1
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAuthor(int id)
    {
        var author = await _context.Authors
            .Include(a => a.Books)
            .FirstOrDefaultAsync(a => a.Id == id);

        if (author == null)
            return NotFound();

        return Ok(author);
    }

    // GET: api/authors/1
  [HttpPost]
    public async Task<IActionResult> CreateAuthor([FromBody] Author newAuthor)
    {
        _context.Authors.Add(newAuthor);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetAuthor), new { id = newAuthor.Id }, newAuthor);
    }

    
}

}
