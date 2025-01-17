using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagementSystem.Domain.Entities;
using BookstoreManagementSystem.Domain.ValueObjects;

namespace BookstoreManagementSystem.TestUnit.OrderTests
{
    public class OrderTests
    {
        [Fact]
        public void Should_Create_Valid_Order()
        {
            var customerId = 1;
            var order = new Order(customerId);

            Assert.Equal(customerId, order.CustomerId);
            Assert.Empty(order.Books);
            Assert.Equal(0, order.TotalAmount);
        }

        [Fact]
        public void Should_Add_Book_To_Order()
        {
            var order = new Order(1);
            var book = new Book("Test Book", new Money(19.99m, "USD"),1,2);

            order.AddBook(book);

            Assert.Single(order.Books);
            Assert.Equal(19.99m, order.TotalAmount);
        }

        [Fact]
        public void Should_Remove_Book_From_Order()
        {
            var order = new Order(1);
            var book = new Book("Test Book", new Money(19.99m,"USD"),1,2);
            order.AddBook(book);

            order.RemoveBook(book);

            Assert.Empty(order.Books);
            Assert.Equal(0,order.TotalAmount);
        }

        [Fact]
        public void Should_Add_Multiple_Books_To_Order()
        {
            var order = new Order(1);
            var book1 = new Book("Book 1", new Money(19.99m,"USD"),1,2);
            var book2 = new Book("Book 2", new Money(13.69m,"USD"),1,3);

            order.AddBook(book1);
            order.AddBook(book2);

            Assert.Equal(2, order.Books.Count);
            Assert.Equal(33.68m, order.TotalAmount);
        }
    }
}