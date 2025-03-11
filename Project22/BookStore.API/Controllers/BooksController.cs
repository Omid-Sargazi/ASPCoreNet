using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.API.Models;
using BookStore.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController:ControllerBase
    {
         private readonly IBookRepository _bookRepository;
        private readonly ILogger<BooksController> _logger;
        
        public BooksController(
            IBookRepository bookRepository,
            ILogger<BooksController> logger)
        {
            _bookRepository = bookRepository;
            _logger = logger;
        } 



        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetBooks()
        {
            try
            {
                var books = await _bookRepository.GetAllBooksAsync();
                var bookDtos = books.Select(book => new BookDto
                {
                    Id = book.Id,
                    Title = book.Title,
                    Description = book.Description,
                    PublishedDate = book.PublishedDate,
                    Price = book.Price,
                    AuthorId = book.AuthorId,
                    AuthorName = book.Author?.Name,
                    ISBN = book.ISBN,
                    IsAvailable = book.IsAvailable
                });
                
                return Ok(bookDtos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting all books");
                return StatusCode(StatusCodes.Status500InternalServerError, 
                    "Error retrieving data from the database");
            }
        }  
    }
}