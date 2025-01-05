using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domin.Entities;
using CleanArchitecture.Infrastructure;
using CleanArchitecture.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.UnitTests.Services
{
    public class TodoRepositoryTests
    {
        private readonly ITodoRepository _repository;

        public TodoRepositoryTests(ITodoRepository repository)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase("TestDatabase").Options;

            var context = new ApplicationDbContext(options);
            _repository = new TodoRepository();
            // _repository = repository;
        }

        [Fact]
        public async Task AddAsync_ShouldAddTodoItem()
        {
            var todo = new TodoItem {Title = "Test Todo", IsComplete = false};
            await _repository.AddAsync(todo);

            var allTodos = await _repository.GetAllAsync();
            Assert.Single(allTodos);
        }


    }
}