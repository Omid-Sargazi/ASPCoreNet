using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CleanArchitectureExample.Application.Features.Projects.Commands
{
    public class UpdateProjectCommand:IRequest<bool>
    {
        public Guid Id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
    }
}