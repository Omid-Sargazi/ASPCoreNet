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
    }
}