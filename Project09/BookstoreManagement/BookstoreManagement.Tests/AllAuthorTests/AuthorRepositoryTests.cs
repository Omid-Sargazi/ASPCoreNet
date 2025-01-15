using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagement.Domain.Entities;
using BookstoreManagement.Infrastructure.Data;
using BookstoreManagement.Infrastructure.Repositories;
using Xunit;

namespace BookstoreManagement.Tests.AllAuthorTests
{
    public class AuthorRepositoryTests
    {
        [Fact]
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
    }
}