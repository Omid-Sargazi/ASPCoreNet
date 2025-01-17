using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagementSystem.Domain.Entities;
using BookstoreManagementSystem.Domain.ValueObjects;

namespace BookstoreManagementSystem.TestUnit.CustomerTests
{
    public class CustomerTests
    {
        [Fact]
        public void Should_Create_Valid_Customer()
        {
            var name = "Customer name";
            var email = new Email("customer@test.com");

            var customer = new Customer(name, email);

            Assert.Equal(name, customer.Name);
            Assert.Equal(email, customer.Email);
            Assert.Empty(customer.Orders);
        }

        [Fact]
        public void Should_Throw_Exception_When_Email_Is_Invalid()
        {
            Assert.Throws<ArgumentException>(()=> new Customer("Customer Name", new Email("Invalid_Email")));
        }
    }
}