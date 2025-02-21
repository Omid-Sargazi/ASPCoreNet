using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TestLibrarySystem.API.Models;

namespace TestLibrarySystem.Test.IntegrationTests
{
    public class BooksControllerTests:IClassFixture<CustomWebApplicationFactory>
    {
        private readonly HttpClient _client;

        public BooksControllerTests(CustomWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Test");
        }

        [Fact]
        public async Task GetBooks_ReturnsSuccessAndCorrectContent()
        {
            var response = await _client.GetAsync("/api/books/get-Books");

            response.EnsureSuccessStatusCode();

            var books = await response.Content.ReadFromJsonAsync<List<Book>>();
            Assert.NotNull(books);
            Assert.Equal(3, books.Count);
            Assert.Contains(books, b=>b.Title == "Test Book 1");
        }

        [Fact]
        public async Task GetBook_WithValidId_ReturnsBook()
        {
            var response = await _client.GetAsync("api/books/1");

            response.EnsureSuccessStatusCode();
            var book = await response.Content.ReadFromJsonAsync<Book>();
            Assert.NotNull(book);
            Assert.Equal("Test Book 1", book.Title);
        }

        [Fact]
        public async Task GetBook_WithInvalidId_ReturnsNotFound()
        {
            var response = await _client.GetAsync("api/books/999");
            
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task CreateBook_WithValidData_ReturnsCreated()
        {
            var  newBook = new Book {Title = "New Book", Author = "New Author", Price = 20.00m};
            var resposne = await _client.PostAsJsonAsync("/api/books",newBook);

            Assert.Equal(HttpStatusCode.Created, resposne.StatusCode);
            var createdBook = await resposne.Content.ReadFromJsonAsync<Book>();
            Assert.NotNull(createdBook);
            Assert.Equal("New Book", createdBook.Title);
            Assert.True(createdBook.Id > 0);
        }
    }
}