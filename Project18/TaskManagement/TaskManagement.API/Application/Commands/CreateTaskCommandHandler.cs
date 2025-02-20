using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using TaskManagement.API.Application.DTOs;
using TaskManagement.API.Domain.Entities;
using TaskManagement.API.Domain.Infrastructure.Persistence;

namespace TaskManagement.API.Application.Commands
{
    public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, TaskDto>
    {
        private readonly TaskDbContext _taskDbContext;

        public CreateTaskCommandHandler(TaskDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }
        public async Task<TaskDto> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
           var task = new Tassk
           {
                Title = request.Title,
                Description = request.Description,
                DueDate = request.DueDate,
                IsCompleted = false,
           };

           _taskDbContext.Add(task);
           await _taskDbContext.SaveChangesAsync(cancellationToken);

           return new TaskDto
           {
                Id = task.Id,
                Title = task.Title,
                DueDate = task.DueDate,
                IsCompleted = task.IsCompleted,

           };
        }
    }
}