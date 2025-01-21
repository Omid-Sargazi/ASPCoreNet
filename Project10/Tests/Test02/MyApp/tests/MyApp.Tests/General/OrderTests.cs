using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using MyApp.Domain.Entities;

namespace MyApp.Tests.General
{
    public class OrderTests
    {
        [Fact]
        public void CreateOrder_ShouldInitializeCorrectly()
        {
            var order = new Order();

            order.OrderDate.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(1));
            order.Products.Should().BeEmpty();
        }
    }
}