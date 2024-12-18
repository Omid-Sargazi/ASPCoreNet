using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApp.Data;
using Xunit;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Tests
{
    public class AppDbContextTests
{
    [Fact]
    public void CanInsertProductIntoDatabase()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        using (var context = new AppDbContext(options))
        {
            var product = new Product { Name = "Test Product", Price = 9.99m };
            context.Products.Add(product);
            context.SaveChanges();

            Assert.Equal(1, context.Products.Count());
            Assert.Equal("Test Product", context.Products.Single().Name);
        }
    }
}
}