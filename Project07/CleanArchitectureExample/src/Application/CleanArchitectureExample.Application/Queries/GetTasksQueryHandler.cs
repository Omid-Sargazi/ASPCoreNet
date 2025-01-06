using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitectureExample.Domain.Entities;
using CleanArchitectureExample.Domain.Interfaces;
using MediatR;

namespace CleanArchitectureExample.Application.Queries
{
    public class GetTasksQueryHandler : IRequestHandler<GetTasksQuery, IEnumerable<TaskItem>>
    {

        private readonly IRepository<TaskItem> _repository;

        public GetTasksQueryHandler(IRepository<TaskItem> repository)
        {
            _repository = repository;
        }   
        public async Task<IEnumerable<TaskItem>> Handle(GetTasksQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync();
        }
    }
}