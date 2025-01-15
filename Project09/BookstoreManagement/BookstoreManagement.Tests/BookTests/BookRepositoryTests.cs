using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure;
using BookstoreManagement.Domain.Entities;
using BookstoreManagement.Infrastructure.Data;
using BookstoreManagement.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace BookstoreManagement.Tests.BookTests
{
    public class BookRepositoryTests
    {
       // [Fact]
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

       // [Fact]
        public async Task AddAsync_ShouldAddBookToDatabase()
        {
            var context = TestDbContextFactory.Create();
            var repository = new BookRepository(context);

            var book = new Book("new book", 15.99m, 1,1);

            await repository.AddAsync(book);

            // var savedBook = await repository.GetAllAsync();
            var savedBook = await context.Books.FirstOrDefaultAsync();

            Assert.NotNull(savedBook);
            Assert.Equal("new book", savedBook.Title);
            Assert.Equal(15.99m, savedBook.Price);
        }

       // [Fact]
        public async Task GetByIdAsync_ShouldReturnBookWithRelations()
        {
            var context = TestDbContextFactory.Create();
            var repository = new BookRepository(context);

            var author = new Author("Author name");
            var category = new Category("Fiction");
            var inventory = new Inventory(1,100);
            var book = new Book("Book title", 19.99m, 1,1, author, category,inventory);

            context.Authors.Add(author);
            context.Categories.Add(category);
            context.Books.Add(book);
            await context.SaveChangesAsync();

            var retrievedBook = await context.Books.FindAsync(book.Id);

            //Assert
            Assert.NotNull(retrievedBook);
            Assert.Equal("Book title",retrievedBook.Title);
        }

        //[Fact]
        public async Task DeleteAsync_ShouldRemoveBookFromDatabase()
        {
            var context = TestDbContextFactory.Create();
            var repository= new BookRepository(context);

            var book = new Book("Book to Delete", 9.99m, 1, 1);
            context.Books.Add(book);
            await context.SaveChangesAsync();
            // await context.Books.Remove(book);

            await repository.DeleteAsync(book.Id);

            var deletedBook = await context.Books.FirstOrDefaultAsync(b=>b.Id==book.Id);
            Assert.Null(deletedBook);
        }
    }
}