using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using Tests01.Domain.Data;
using Tests01.Domain.Models;
using Tests01.WebApi.Controllers;

namespace Tests01.UnitTest.Tests
{
    public class BooksControllerTests
    {
        private readonly BooksController _controller;
        // private readonly Mock<IApplicationDbContext> _mockContext;
        private readonly ApplicationDbContext _dbContext;

        public BooksControllerTests()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName:"TestDatabase").Options;

            _dbContext = new ApplicationDbContext(options);
            _controller = new BooksController(_dbContext);
        }

        [Fact]
        public async Task GetBooks_ReturnsAllBooks()
        {
            var author = new Author{Id = 1, Name = "Author 1"};
            var book = new Book {Id =1, Title = "Book 1", AuthorId = 1, Author = author};

            _dbContext.Authors.Add(author);
            _dbContext.Books.Add(book);
            await _dbContext.SaveChangesAsync();

            var result = await _controller.GetBooks();

            var actionResult = Assert.IsType<ActionResult<List<Book>>>(result);
            var returnValue = Assert.IsType<List<Book>>(actionResult.Value);
            Assert.Single(returnValue);
            Assert.Equal("Book 1", returnValue[0].Title);
        }

        [Fact]
        public async Task CreateBook_ReturnsCreatedAtActionResult()
        {
            var author = new Author {Id = 1, Name = "Author 1"};
            var book = new Book {Title="new Book", AuthorId = 1, Author = author};

            _dbContext.Authors.Add(author);
            await _dbContext.SaveChangesAsync();

            var result = _controller.CreateBook(book);


            var actionResult = Assert.IsType<CreatedAtActionResult>(result);
            var returnValue = Assert.IsType<Book>(actionResult.Value);
            Assert.Equal("Book", returnValue.Title);


        }
    }
}