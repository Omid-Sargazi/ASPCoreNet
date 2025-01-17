using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagementSystem.Domain.Entities;
using BookstoreManagementSystem.Domain.ValueObjects;

namespace BookstoreManagementSystem.TestUnit.BookTests
{
    public class BookTests
    {
        [Fact]
        public void Should_Create_Valid_Book()
        {
            var book = new Book("Test Book", new Money(19.99m, "USD"), 1, 2);

            Assert.Equal("Test Book", book.Title);
            Assert.Equal(19.99m, book.Price.Amount);
            Assert.Equal("USD", book.Price.Currency);
        }

        [Fact]
        public void Should_Throw_Exception_For_Empty_Title()
        {
            Assert.Throws<ArgumentException>(()=> new Book("",new Money(18.99m,"USD"),1,2));
        }
    }
}