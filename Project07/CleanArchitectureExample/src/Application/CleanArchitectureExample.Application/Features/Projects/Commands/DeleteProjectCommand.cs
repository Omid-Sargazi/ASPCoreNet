using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CleanArchitectureExample.Application.Features.Projects.Commands
{
    public class DeleteProjectCommand:IRequest<bool>
    {
        public Guid Id {get; set;}
    }
}