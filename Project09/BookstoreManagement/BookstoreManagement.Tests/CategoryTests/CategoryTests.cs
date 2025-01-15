using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure;
using BookstoreManagement.Domain.Entities;
using BookstoreManagement.Infrastructure.Data;
using BookstoreManagement.Infrastructure.Repositories;
using Xunit;

namespace BookstoreManagement.Tests.CategoryTests
{
    public class CategoryTests
    {
       // [Fact]
        public void Category_ShouldBeCreated_WhenValidParametersAreProvided()
        {
            var name = "Test Category";

            var category = new Category(name);

            Assert.Equal(name, category.Name);
            Assert.Null(category.Books);
        }

        //[Fact]
        public void Category_ShouldThrowException_WhenNameIsEmpty()
        {
            Assert.Throws<ArgumentException>(() => new Category(null));
        }

        //[Fact]
        public void Category_ShouldThrowException_WhenNameIsNull()
        {
            Assert.Throws<ArgumentException>(() => new Category(""));
        }

        [Fact]
        public async Task GetAllAsync_ShouldReturnCategoriesWithBooks()
        {
            var context = TestDbContextFactory.Create();
            var repository = new CategoryRepository(context);

            var category = new Category("Fiction");
            var book = Book.Create("Test Book", 19.99m, 1, 1,category);

            context.Categories.Add(category);
            context.Books.Add(book);
            await context.SaveChangesAsync();

            var categories = await repository.GetAllAsync();

            Assert.Single(categories);
            var retrievedCategory = categories[0];
            Assert.Equal("Fiction",retrievedCategory.Name);
            Assert.Single(retrievedCategory.Books);
        }
    }
}