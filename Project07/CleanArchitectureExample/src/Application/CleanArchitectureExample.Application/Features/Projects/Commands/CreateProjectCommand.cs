using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CleanArchitectureExample.Application.Features.Projects.Commands
{
    public class CreateProjectCommand:IRequest<Guid>
    {
        public string Name {get; set;}
        public string Description {get; set;}
    }
}