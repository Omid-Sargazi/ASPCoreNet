using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreAPIs.Models;
using BookStoreAPIs.Models.DTOs;
using BookStoreAPIs.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPIs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController:ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        private readonly ILogger<BookRepository> _logger;

        public BooksController(IBookRepository bookRepository, ILogger<BookRepository> logger)
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
                    IsAvailable = book.IsAvailable,
                });

                return Ok(bookDtos);
            }
            catch (Exception ex)
            {
                
                _logger.LogError(ex,"Error getting all books");
                return StatusCode(StatusCodes.Status500InternalServerError,"Error retrieving data from the database");
            }
        }
    }
}