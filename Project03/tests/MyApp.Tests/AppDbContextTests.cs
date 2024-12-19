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
    }

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

    public void CannotAddDuplicateNames()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
        .UseInMemoryDatabase(databaseName:"UniqueConstraintTest").Options;

        using(var context = new AppDbContext(options))
        {
            context.Products.Add(new Product{Name="Mouse",Price=25m});
            context.Products.Add(new Product{Name="Mouse02",Price=25m});
            
            Assert.Throws<DbUpdateException>(() => context.SaveChanges());

        }
    }

    [Fact]
    public void CanInsertCategoryWithProducts()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
        .UseInMemoryDatabase(databaseName:"CategoryWithProductsTest").Options;

        using(var context = new AppDbContext(options))
        {
            var category = new Category
            {
                Name="Electronics",
                Products=new List<Product>
                {
                    new Product{Name="TV",Price=20m},
                    new Product{Name="Laptop",Price=201m},
                }
            };

            context.Add(category);
            context.SaveChanges();


            var savedCategory = context.Categories.Include(c=>c.Products).Single();
            Assert.Equal(2,savedCategory.Products.Count);
            Assert.Equal("TV",savedCategory.Products.First().Name);
        }
    }

    [Fact]
    public void Test_Addition_ReturnsCorrectSum()
    {
        
        Assert.Equal(5,3+2);
    }


    [Theory]
    [InlineData(2,3,5)]
    [InlineData(1,2,30)]
    public void Test_Addition_MultipleCases(int a, int b, int expected)
    {
        Assert.Equal(expected,a+b);
    }

    [Fact]
    public void Test_DivideByZero_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(()=>{int result = 1 / 2;});
    

    [Fact]
    public void Test_ObjectIsNull()
    {
        object obj=null;
        Assert.Null(obj);
    } 
    }
    [Fact]
    public void ValidateInput_ThrowsException_ForInvalidData()
    {
        string invalidInput = null;

        try{
            ValidateInput(invalidInput);
        }catch(ArgumentException ex)
        {
            Console.WriteLine($"Exception Caught: {ex.Message}");
            Assert.Equal("Input cannot be empty or null", ex.Message);
            return;
        }



        Assert.Throws<ArgumentException>(()=>ValidateInput(invalidInput));
    }

    private void ValidateInput(string input)
    {
        if(string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Omidhello");
            throw new ArgumentException("Input cannot be empty or null");
        }
    }



    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        var Calculator = new Calculator();
        int result = Calculator.Add(10,10);
        Assert.Equal(10, result);
    }

    public class Calculator
    {
        public int Add(int a, int b)=>a+b;
    }*/




    [Fact]
    public void AddCategory_SavesCategoryToDatabase()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
        .UseInMemoryDatabase("TestDatabase").Options;

        using(var context = new AppDbContext(options))
        {
            var category = new Category{Name="Electronics"};
            context.Categories.Add(category);
            context.SaveChanges();


            var savedCategory = context.Categories.Single();
            Assert.Equal("Elect",savedCategory.Name);
        }
    }
}
}