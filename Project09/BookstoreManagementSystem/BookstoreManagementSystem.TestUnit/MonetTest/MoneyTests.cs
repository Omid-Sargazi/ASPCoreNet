using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagementSystem.Domain.Exceptions;
using BookstoreManagementSystem.Domain.ValueObjects;

namespace BookstoreManagementSystem.TestUnit.MonetTest
{
    public class MoneyTests
    {
        [Fact]
        public void Should_Create_Valid_Money()
        {
            var money = new Money(10.99m, "USD");
            Assert.Equal(10.99m,money.Amount);
            Assert.Equal("USD", money.Currency);
        }

        [Fact]
        public void Should_Throw_Exception_For_Negative_Amount()
        {
            Assert.Throws<InvalidPriceException>(()=>new Money(-1,"USD"));
        }
       
    }
}