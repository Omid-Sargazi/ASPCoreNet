using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CleanArchitectureExample.Application.Features.Users.Commands
{
    public class UpdateUserCommand:IRequest<bool>
    {
        public string Id {get; set;}
         public string UserName { get; set; }
        public string Email { get; set; }
    }
}