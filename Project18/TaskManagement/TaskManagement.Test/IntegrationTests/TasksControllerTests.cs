using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using TaskManagement.API.Application.Commands;
using TaskManagement.API.Application.DTOs;

namespace TaskManagement.Test.IntegrationTests
{
    public class TasksControllerTests:IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;
        private readonly HttpClient _client;

        public TasksControllerTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
            _client = factory.CreateClient();
        }
        [Fact]
       public async Task CreateTask_ReturnCreateTask()
       {
            var command = new CreateTaskCommand
            {
                Title = "Task 1",
                Description = "this is a task",
                DueDate = DateTime.UtcNow.AddDays(1)
            };

            var resposne = await _client.PostAsJsonAsync("/api/tasks", command);
            var createdTask = await resposne.Content.ReadFromJsonAsync<TaskDto>();

            Assert.True(resposne.IsSuccessStatusCode);

       }
    }
}