using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagement.Domain.Entities;
using Xunit;

namespace BookstoreManagement.Tests.BookTests
{
    public class BookTests
    {
        //[Fact]
        public void Book_ShouldBeCreated_WhenValidParametersAreProvided()
        {
            var title = "Test Book";
            var price = 19.99m;
            var authorId = 1;
            var categoryId = 2;

            var book = new Book(title,price, authorId, categoryId);
            Assert.Equal(title, book.Title);
            Assert.Equal(price, book.Price);
            Assert.Equal(authorId, book.AuthorId);
            Assert.Equal(categoryId, book.CategoryId);
        }

        //[Fact]
        public void Book_ShouldThrowException_WhenTitleIsEmpty()
        {
            var price = 19.99m;
            var authorId = 1;
            var categoryId = 2;
            var title = "Test Book";


            Assert.Throws<ArgumentException>(()=>new Book("", price,authorId, categoryId));
        }
    }
}