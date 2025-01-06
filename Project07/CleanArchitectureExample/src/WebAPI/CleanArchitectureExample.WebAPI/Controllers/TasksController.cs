using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitectureExample.Application.Commands.CreateTask;
using CleanArchitectureExample.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureExample.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController:ControllerBase
    {
        private readonly IMediator _mediator;

        public TasksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTasks()
        {
            var query = new GetTasksQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> CreateTask([FromBody] CreateTaskCommand command)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetAllTasks), new {id = result}, result);
        }
    }
}