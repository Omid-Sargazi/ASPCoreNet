using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using MyApp.Domain.Entities;
using MyApp.Infrastructure.Persistence;
using MyApp.Infrastructure.Repositories;

namespace MyApp.Tests.General
{
    public class ProductRepositoryTests
    {
        private async Task<ApplicationDbContext> GetDatabaseContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            var context = new ApplicationDbContext(options);

            // Seed data
            var category = new Category("Electronics");
            var product1 = new Product("Laptop", 1000m, category);
            var product2 = new Product("Phone", 500m, category);

            await context.Categories.AddAsync(category);
            await context.Products.AddRangeAsync(product1, product2);
            await context.SaveChangesAsync();

            return context;
        }

       [Fact]
        public async Task GetAllAsync_ShouldReturnAllProducts()
        {
            var context = await GetDatabaseContext();
            var productRepository = new ProductRepository(context);

            var products = await productRepository.GetAllAsync();

            products.Should().HaveCount(2);
        }
    }
}