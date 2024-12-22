using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestfullAPIs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController:ControllerBase
    {
        private static List<Book> Books = new List<Book>
        {
            new Book{Id=1,Title="C# Basics",Author = "John Doe"},
            new Book{Id = 2, Title = "ASP.NET Core", Author = "Jane Smith"}
        };


        [HttpGet]
        public IActionResult GetBook(int id)
        {
            var book = Books.FirstOrDefault(b=>b.Id==id);
            if(book==null)
            {
                return NotFound();
            }
            return Ok(book);
        }
    }





    public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
}
}