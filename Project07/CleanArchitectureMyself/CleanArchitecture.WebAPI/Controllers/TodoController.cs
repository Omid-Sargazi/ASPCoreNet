using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domin.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController:ControllerBase
    {
        private readonly ITodoRepository _repository;

        public TodoController(ITodoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var todo = await _repository.GetAllAsync();
            return Ok(todo);
        }

        [HttpPost]
        public async Task<IActionResult> Add(TodoItem item)
        {
            await _repository.AddAsync(item);
            return CreatedAtAction(nameof(GetAll), new { id = item.Id }, item);
        }
    }
}