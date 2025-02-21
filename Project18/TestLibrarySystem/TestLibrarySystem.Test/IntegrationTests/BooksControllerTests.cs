using System;
using System.Collections.Generic;
using System.Linq;
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
        }

        [Fact]
        public async Task GetBooks_ReturnsSuccessAndCorrectContent()
        {
            var response = await _client.GetAsync("/api/books/get-Books");

            response.EnsureSuccessStatusCode();

            var books = await response.Content.ReadFromJsonAsync<List<Book>>();
            Assert.NotNull(books);
            Assert.Equal(2, books.Count);
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
    }
}