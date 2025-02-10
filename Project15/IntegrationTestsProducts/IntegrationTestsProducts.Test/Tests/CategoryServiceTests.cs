using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegrationTestsProducts.API.Data;
using IntegrationTestsProducts.API.Models;
using IntegrationTestsProducts.API.Services;
using Microsoft.EntityFrameworkCore;

namespace IntegrationTestsProducts.Test.Tests
{
    public class CategoryServiceTests:IClassFixture<TestDbContext>
    {
        private readonly AppDbContext _context;
        private readonly CategoryService _categoryService;

        public CategoryServiceTests(TestDbContext dbContext)
        {
            _context = dbContext.Context;
            _categoryService = new CategoryService(_context);
        }

        // [Fact]
        public async Task CreateCategory_ShouldAddCategory()
        {
            var category = new Category {Name = "Electronics"};

            var result = await _categoryService.CreateCategoryAsync(category);

            Assert.NotNull(result);
            Assert.Equal("Electronics",result.Name);
            Assert.Equal(1,await _context.Categories.CountAsync());
        }

        [Fact]
        public async Task GetCategoryById_ShouldReturnCorrectCategory()
        {
            var category = new Category {Name = "Books"};
            await _categoryService.CreateCategoryAsync(category);

            var result = await _categoryService.GetCategoryByIdAsync(category.Id);

            Assert.NotNull(result);
            Assert.Equal("Books", result.Name);
            Assert.Equal(1, result.Id);
        }
    }
}