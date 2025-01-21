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
        
        [Fact]
        public void AddProduct_ShouldAddToOrder()
        {
            var category = new Category("Appliances");
            var product  = new Product("Refrigerator", 500m, category);
            var order = new Order();

            order.AddProduct(product);

            order.Products.Should().ContainSingle();
            Assert.Contains(product,order.Products);
            order.Products[0].Should().Be(product);
            Assert.Equal(product, order.Products[0]);
        }

        [Fact]
        public void GetTotalAmount_ShouldReturnCorrectTotal()
        {
            var category = new Category("Appliances");
            var order = new Order();

            order.AddProduct(new Product("Fridge", 500m, category));
            order.AddProduct(new Product("Washing Machine", 300m, category));

            order.GetTotalAmount().Should().Be(800m);   
        }

    }
}