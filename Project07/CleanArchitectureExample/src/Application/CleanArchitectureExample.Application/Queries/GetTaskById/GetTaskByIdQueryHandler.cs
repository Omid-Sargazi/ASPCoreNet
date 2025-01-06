using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitectureExample.Application.DTOs;
using CleanArchitectureExample.Domain.Entities;
using CleanArchitectureExample.Domain.Interfaces;
using MediatR;

namespace CleanArchitectureExample.Application.Queries.GetTaskById
{
    public class GetTaskByIdQueryHandler : IRequestHandler<GetTaskByIdQuery, TaskItemDto>
    {
        private readonly IRepository<TaskItem> _repository;

        public GetTaskByIdQueryHandler(IRepository<TaskItem> repository)
        {
            _repository = repository;
        }


        public async Task<TaskItemDto?> Handle(GetTaskByIdQuery request, CancellationToken cancellationToken)
        {
            var task = await _repository.GetByIdAsync(request.TaskId);
            if(task ==null)
            {
                return null;
            }

            return new TaskItemDto
            {
                Id=request.TaskId,
                Title = task.Title,
                Description = task.Description,
                CreatedAt = task.CreatedAt,
                DueDate = task.DueDate,
                UserId = task.UserId,
                ProjectId = task.ProjectId
            };
        }
    }
}