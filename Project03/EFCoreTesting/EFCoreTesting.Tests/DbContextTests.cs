using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreTesting.Data;
using EFCoreTesting.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTesting.Tests
{
    public class DbContextTests
    {
        private AppDbContext GetInMemoryDbContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName:"TestDataBase").Options;

            return new AppDbContext(options);
        }


        [Fact]
        public void AddProduct_ShouldSaveToDatabase()
        {
            using var context  = GetInMemoryDbContext();
            var product = new Product{Name = "Test Product", Price = 10.99m};

            context.Products.Add(product);
            context.SaveChanges();

            Assert.Equal(1,context.Products.Count());
            Assert.Equal("Test Product",context.Products.Single().Name);
        }

        [Fact]
        public void GetProducts_ShouldReturnAllProducts()
        {
            using var context = GetInMemoryDbContext();

            context.Products.Add(new Product{Name = "Product 1", Price=5.99m});
            context.Products.Add(new Product{ Name = "Product 2", Price=15.99m});
            context.SaveChanges();


            var products = context.Products.ToList();

            Assert.Equal(3,products.Count);
        }
    }
}