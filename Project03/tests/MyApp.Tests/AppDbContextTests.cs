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
   /* [Fact]
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

    [Fact]
    public void CanUpdateProduct()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
        .UseInMemoryDatabase(databaseName:"UpdateProductTest").Options;

        using(var context = new AppDbContext(options))
        {
            var product = new Product{Name="Phone",Price=500m};
            context.Products.Add(product);
            context.SaveChanges();

            var existingProduct = context.Products.Single();
            existingProduct.Price=450m;
            context.SaveChanges();

            Assert.Equal(450m,context.Products.Single().Price);

        }
    }

    [Fact]
    public void CanDeleteProduct()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
        .UseInMemoryDatabase(databaseName:"DeleteProductTest").Options;

        using(var context = new AppDbContext(options))
        {
            var product = new Product{Name="IPhone",Price=152m};
            context.Products.Add(product);
            context.SaveChanges();

            context.Products.Remove(product);
            context.SaveChanges();

            Assert.Empty(context.Products);
        }
    }*/

    [Fact]
    public void CanQueryProductByName()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
        .UseInMemoryDatabase(databaseName:"QueryByNameTest").Options;

        using(var context = new AppDbContext(options))
        {
            context.Products.Add(new Product{Name="Monitor",Price=120m});
            context.Products.Add(new Product{Name="KeyBoard",Price=25m});

            context.SaveChanges();

            var result = context.Products.Single(p=>p.Name=="Monitor");
            Assert.NotNull(result);
            Assert.Equal(120,result.Price);
        }
    }

    
}
}