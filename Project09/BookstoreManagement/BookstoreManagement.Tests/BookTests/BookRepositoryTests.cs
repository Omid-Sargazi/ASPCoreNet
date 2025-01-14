using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagement.Domain.Entities;
using BookstoreManagement.Infrastructure.Data;
using BookstoreManagement.Infrastructure.Repositories;
using Xunit;

namespace BookstoreManagement.Tests.BookTests
{
    public class BookRepositoryTests
    {
        [Fact]
        public async Task GetAllAsync_ShouldReturnBooksWithRelations()
        {
            var context = TestDbContextFactory.Create();
            var repository = new BookRepository(context);

            var author = new Author("Author Name");
            var category = new Category("Fiction");
            var inventory= new Inventory(1,100);
            var book = new Book("Book Title", 19.99m, 1, 1, author, category, inventory);
            // {
            //     Author = author,
            //     Category=category,
            //     Inventory = new Inventory(1,100)
            // };

            context.Authors.Add(author);
            context.Categories.Add(category);
            context.Books.Add(book);
            await context.SaveChangesAsync();

            //Act
            var books = await repository.GetAllAsync();

            Assert.Single(books);
            var retrievedBook = books[0];

            Assert.Equal("Book Title", retrievedBook.Title); 
            Assert.Equal(19.99m, retrievedBook.Price);
            Assert.Equal("Author Name", retrievedBook.Author.Name);
            Assert.Equal("Fiction", retrievedBook.Category.Name);
            Assert.Equal(100, retrievedBook.Inventory.Quantity);

        }
    }
}