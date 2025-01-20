using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tests01.Domain.Models;
using Tests01.Domain.Repository;

namespace Tests01.WebApi.Controllers
{
    [ApiController]
    [Route("/api[controller]")]
    public class BooksControllerByRepo:ControllerBase
    {
        private readonly IBookRepository _repository;

        public BooksControllerByRepo(IBookRepository bookRepository)
        {
            _repository = bookRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            var books = await _repository.GetBooksAsync();
            return Ok(books);
        }

        [HttpPost]
        public async Task<ActionResult<Book>> CreateBook(Book book)
        {
            await _repository.CreateBookAsync(book);
            return CreatedAtAction(nameof(GetBooks), new{ id = book.Id },book);
        }
    }
}