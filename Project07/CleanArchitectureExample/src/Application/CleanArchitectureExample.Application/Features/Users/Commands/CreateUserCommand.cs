using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CleanArchitectureExample.Application.Features.Users.Commands
{
    public class CreateUserCommand:IRequest<string>
    {
        public string UserName {get;set;}
        public string Email {get; set;}
        public string Password {get; set;}
    }
}