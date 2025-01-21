using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApp.Domain.Entities;

namespace MyApp.Tests.General
{
    public class ProductTests
    {
        //[Fact]
        public void CreateProduct_ShouldInitializeCorrectly()
        {
            var category = new Category("Electronics");
            var product = new Product("Laptop", 1200m, category);

            //Assert.Equal("Laptop", product.Name);
            //Assert.Equal(12000m, product.Price);
            Assert.Equal(category.Name, product.Category.Name);
        }

        //[Fact]
        public void CreateProduct_ShouldThrowException_WhenPriceIsNegative()
        {
            var category = new Category("Electronics");

           var exception = Assert.Throws<ArgumentException>(()=>new Product("Laptop", -1200m, category));

           Assert.Equal("Price cannot be negative.", exception.Message);
        }
        
        //[Fact]

    }
}