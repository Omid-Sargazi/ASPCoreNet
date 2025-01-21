using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using MyApp.Domain.Entities;

namespace MyApp.Tests.General
{
    public class CategoryTests
    {
        [Fact]
        public void CreateCategory_ShouldInitializeCorrectly()
        {
            var category = new Category("Books");

            category.Name.Should().Be("Books");
            category.Products.Should().BeEmpty();

            Assert.Equal("Books",category.Name);
            Assert.Empty(category.Products);


        }
        [Fact]
        public void AddProduct_ShouldAddToCategory()
        {
            var category = new Category("Books");
            var product = new Product("Book1", 15m, category);

            category.AddProduct(product);

            // category.Products.Should().Contain(product);
            // Assert.Contains(product, category.Products);

            category.Products.Should().Contain(product);
            category.Products.Should().ContainSingle();
            Assert.Contains(product, category.Products);
            category.Products[0].Should().Be(product);
        }
    }
}