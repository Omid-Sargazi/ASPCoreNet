using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitectureExample.Application.DTOs.Project;
using MediatR;

namespace CleanArchitectureExample.Application.Features.Projects.Queries
{
    public class GetProjectByIdQuery:IRequest<ProjectDto>
    {
        public Guid Id {get; set;}
    }
}