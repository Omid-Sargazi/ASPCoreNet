using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitectureExample.Application.DTOs.User;
using MediatR;

namespace CleanArchitectureExample.Application.Features.Users.Queries
{
    public class GetUserByIdQuery:IRequest<UserDto>
    {
        public string Id {get; set;}
    }
}