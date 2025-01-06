using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitectureExample.Domain.Entities;
using MediatR;

namespace CleanArchitectureExample.Application.Queries
{
    public class GetTasksQuery:IRequest<IEnumerable<TaskItem>>{}
}