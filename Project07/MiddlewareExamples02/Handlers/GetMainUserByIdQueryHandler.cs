using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MiddlewareExamples02.Exceptions;
using MiddlewareExamples02.Models;
using MiddlewareExamples02.Requests;

namespace MiddlewareExamples02.Handlers
{
    public class GetMainUserByIdQueryHandler : IRequestHandler<GetMainUserByIdQuery, UserDto>
    {
        public Task<UserDto> Handle(GetMainUserByIdQuery request, CancellationToken cancellationToken)
        {
            if(request.UserId==Guid.Empty)
            {
                throw new CustomException("Invalid User ID.");
            }

            var user = new UserDto(request.UserId, "Alice", "alice@example.com");
            Console.WriteLine($"User Retrieved: {user}");
            return Task.FromResult(user);
        }
    }
}