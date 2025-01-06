using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CleanArchitectureExample.Application.Features.Users.Commands
{
    public class DeleteUserCommand:IRequest<bool>
    {
        public string Id {get; set;}
    }
}