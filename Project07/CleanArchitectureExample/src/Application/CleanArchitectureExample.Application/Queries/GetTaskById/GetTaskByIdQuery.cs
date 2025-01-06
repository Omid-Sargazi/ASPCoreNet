using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitectureExample.Application.DTOs;
using MediatR;

namespace CleanArchitectureExample.Application.Queries.GetTaskById
{
    public class GetTaskByIdQuery:IRequest<TaskItemDto>
    {
        public Guid TaskId {get;set;}
    }
}