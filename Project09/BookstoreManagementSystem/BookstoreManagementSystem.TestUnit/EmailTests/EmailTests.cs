using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagementSystem.Domain.ValueObjects;

namespace BookstoreManagementSystem.TestUnit.EmailTests
{
    public class EmailTests
    {
        [Fact]
        public void Should_Create_Valid_Email()
        {
            var address = "test@example.com";

            var email = new Email(address);

            Assert.Equal(address, email.Address);
        }

        [Fact]
        public void Should_Throw_Exception_For_Invalid_Email()
        {
            Assert.Throws<ArgumentException>(()=> new Email("Invalid_Address"));
        }
    }
}