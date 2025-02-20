using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using BookstoreManagement.Domain.Entities;
using BookstoreManagement.Infrastructure.Data;
using BookstoreManagement.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace BookstoreManagement.Tests.AllAuthorTests
{
    public class AuthorRepositoryTests
    {
        //[Fact]
        public async Task GetAllAsync_ShouldReturnAuthorsWithBooks()
        {
            var context = TestDbContextFactory.Create();
            var repository = new AuthorRepository(context);

            var author = new Author("Author name");
            var book1 = Book.Create("Book 1", 19.99m, 1, 1, author);
            var book2 = Book.Create("Book 2", 29.99m, 1,1,author);

            context.Authors.Add(author);
            context.Books.AddRange(book1,book2);
            await context.SaveChangesAsync();

            var authors = await repository.GetAllAsync();

            Assert.Single(authors);
            var retrievedAuthor = authors[0];
            Assert.Equal("Author name", retrievedAuthor.Name);
            Assert.Equal(2, retrievedAuthor.Books.Count);

        }

        //[Fact]
        public async Task GetByIdAsync_ShouldReturnAuthorWithBooks()
        {
            var context = TestDbContextFactory.Create();
            var repository = new AuthorRepository(context);

            var author = new Author("Author name");
            var book = Book.Create("Book Title", 19.99m, 1, 1,author);

            context.Books.Add(book);
            context.Authors.Add(author);
            await context.SaveChangesAsync();

            var retrievedAuthor = await repository.GetByIdAsync(author.Id);

            Assert.NotNull(retrievedAuthor);
            Assert.Equal("Omid",retrievedAuthor.Name);
            Assert.Single(retrievedAuthor.Books);
            Assert.Equal("Book Title",retrievedAuthor.Books[0].Title);

        }

        //[Fact]
        public async Task AddAsync_ShouldAddAuthorToDatabase()
        {
            var context = TestDbContextFactory.Create();
            var repository = new AuthorRepository(context);

            var author = new Author("New Author");

            await repository.AddAsync(author);

            var savedAuthor = await context.Authors.FirstOrDefaultAsync();
            Assert.NotNull(savedAuthor);
            Assert.Equal("New Author",savedAuthor.Name);
        }

        //[Fact]
        public async Task DeleteAsync_ShouldRemoveAuthorFromDatabase()
        {
            var context = TestDbContextFactory.Create();
            var repository = new AuthorRepository(context);

            var author = new Author("Author to Delete");
            context.Authors.Add(author);
            await context.SaveChangesAsync();

            await repository.DeleteAsync(author.Id);

            var deletedAuthor = await context.Authors.FirstOrDefaultAsync(a => a.Id == author.Id);
            Assert.NotNull(deletedAuthor);
        }
    }
}