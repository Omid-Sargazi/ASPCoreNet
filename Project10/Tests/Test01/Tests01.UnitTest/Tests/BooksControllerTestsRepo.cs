using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using Tests01.Domain.Data;
using Tests01.Domain.Models;
using Tests01.Domain.Repository;
using Tests01.WebApi.Controllers;

namespace Tests01.UnitTest.Tests
{
   public class BooksControllerTestsRepo
{
    private readonly Mock<IBookRepository> _mockRepository;
    private readonly BooksControllerByRepo _controller;

    public BooksControllerTestsRepo()
    {
        _mockRepository = new Mock<IBookRepository>();

        _controller = new BooksControllerByRepo(_mockRepository.Object);
    }

    [Fact]
    public async Task GetBooks_ReturnsAllBooks()
    {
        // Arrange: Prepare a list of books to return from the mock
        var books = new List<Book>
        {
            new Book { Id = 1, Title = "Book 1", Author = new Author { Id = 1, Name = "Author 1" } },
            new Book { Id = 2, Title = "Book 2", Author = new Author { Id = 2, Name = "Author 2" } }
        };

        // Ensure that the GetBooksAsync method returns the mock data
        _mockRepository.Setup(repo => repo.GetBooksAsync()).ReturnsAsync(books);

        // Act: Call the controller's action
        var result = await _controller.GetBooks();

        // Assert: Verify the result contains the books
        var actionResult = Assert.IsType<ActionResult<IEnumerable<Book>>>(result);
        var returnValue = Assert.IsType<List<Book>>(actionResult.Value);
        Assert.Equal(2, returnValue.Count);
        Assert.Equal("Book 1", returnValue[0].Title);
        Assert.Equal("Book 2", returnValue[1].Title);
    }

    [Fact]
    public async Task CreateBook_CallsCreateBookAsync()
    {
        // Arrange: Prepare a new book
        var book = new Book { Title = "New Book" };

        // Act: Call the CreateBook method
        await _controller.CreateBook(book);

        // Assert: Verify that CreateBookAsync was called
        _mockRepository.Verify(repo => repo.CreateBookAsync(book), Times.Once);
    }
}

}