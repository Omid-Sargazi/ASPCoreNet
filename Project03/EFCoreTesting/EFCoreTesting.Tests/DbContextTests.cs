using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreTesting.Data;
using EFCoreTesting.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

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

        [Fact]
        public void UpdateProduct_ShouldModifyExistingProduct()
        {
            using var context = GetInMemoryDbContext();
            var product = new Product{Name="Old Name",Price=19.99m};
            context.Products.Add(product);
            context.SaveChanges();

            var existingProduct = context.Products.First();
            existingProduct.Name="New Name";
            context.SaveChanges();

            var updateProduct = context.Products.First();
            Assert.Equal("New Name",updateProduct.Name);
            Assert.Equal(19.99m,updateProduct.Price);
        }

        public void DeleteProduct_ShouldRemoveFromDatabase()
        {
            
            using var context = GetInMemoryDbContext();
            var product = new Product{Name = "To Be Deleted",Price=99.99m};
            context.Products.Add(product);
            context.SaveChanges();

            var productDeleted = context.Products.First();
            context.Products.Remove(productDeleted);
            context.SaveChanges();


            Assert.Empty(context.Products);
        }


        [Fact]
        public void AddProduct_WithCategory_ShouldEstablishRelationship()
        {
            using var context = GetInMemoryDbContext();
            var category = new Category {Name="Electronics"};
            var product = new Product{Name="Smartphone",Price=199.36m,Category=category};


            context.Categories.Add(category);
            context.Products.Add(product);
            context.SaveChanges();

            var savedProducts = context.Products.Include(p=>p.Category).First();
            Assert.Equal("Electronics",savedProducts.Category.Name);
        }
    }
}