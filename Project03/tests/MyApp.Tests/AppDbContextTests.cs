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
        .UseInMemoryDatabase(databaseName:"TestDatabase").Options;

        using (var context = new AppDbContext(options))
        {
            var product = new Product{Name="Test",Price=99.9m};
            context.Products.Add(product);
            context.SaveChanges();


            Assert.Equal(1,context.Products.Count());
            Assert.Equal("Test",context.Products.Single().Name);
        }
    }
    [Fact]
    public void DatabaseStartsEmpty()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
        .UseInMemoryDatabase(databaseName:"EmptyDatabaseTest")
        .Options;

        using(var context = new AppDbContext(options))
        {
            var product = new Product{Name="laptop", Price=99.3m};
            context.Products.Add(product);
            context.SaveChanges();
            

            Assert.Empty(context.Products);
        }
    }


    [Fact]
    public void CanAddProduct()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
        .UseInMemoryDatabase(databaseName:"AddProductTest").Options;

        using(var context = new AppDbContext(options))
        {
            var product = new Product{Name="Laptop",Price=1500m};
            var product2 = new Product{Name="PC",Price=1600m};
            context.Products.Add(product);
            context.Products.Add(product2);
            context.SaveChanges();

            Assert.Single(context.Products);
            Assert.Equal("Laptop",context.Products.Single().Name);

        }
    }

    
}
}