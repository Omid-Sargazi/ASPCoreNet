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
    }
}