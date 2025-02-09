using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegrationProductsTest.API.Data;
using IntegrationProductsTest.API.Models;
using IntegrationProductsTest.API.Services;
using Microsoft.EntityFrameworkCore;

namespace IntegrationProductsTest.Test.Tests
{
    public class CategoryServiceTests:IClassFixture<TestDbContext>
    {
        private readonly ApplicationDbContext _context;
        private readonly CategoryService _categoryService;

        public CategoryServiceTests(TestDbContext dbContext)
        {
            _context= dbContext.Context;
            _categoryService = new CategoryService(_context);
        }

        [Fact]
        public async Task CreateCategory_ShouldAddCategory()
        {
            var category = new Category{Name = "Electronics"};
            var result =  await _categoryService.CreateCategoryAsync(category);

            Assert.NotNull(result);
            Assert.Equal("Electronics",result.Name);
            Assert.Equal(1, await _context.Categories.CountAsync());
        }
    }
}