using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitectureExample.Domain.Entities;
using CleanArchitectureExample.Domain.Interfaces;
using MediatR;

namespace CleanArchitectureExample.Application.Commands.CreateTask
{
    public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, Guid>
    {
        private readonly IRepository<TaskItem> _repository;

        public CreateTaskCommandHandler(IRepository<TaskItem> repository)
        {
            _repository = repository;
        }
        public async Task<Guid> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var task = new TaskItem 
            {
                Title = request.Title,
                Description = request.Description,
                DueDate = request.DueDate,
                UserId = request.UserId,
                ProjectId = request.ProjectId,
            };
            await _repository.AddAsync(task);
            return task.Id;
        }
    }
}