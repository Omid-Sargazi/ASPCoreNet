using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatalogContext;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController:ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var books = _bookRepository.GetAll();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetBookById(Guid id)
        {
            var book = _bookRepository.GetById(id);
            return Ok(book);
        }

        [HttpPost]
        public IActionResult AddBook([FromBody] Book book)
        {
            _bookRepository.AddBook(book);
            return CreatedAtAction(nameof(GetBookById), new{id = book.Id},book);
        }
    }
}