using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MiddlewareExamples02.Exceptions;
using MiddlewareExamples02.Requests;

namespace MiddlewareExamples02.Middlewares
{
    public class CreateMainUserCommandHandler : IRequestHandler<CreateMainUserCommand, Guid>
    {
        public Task<Guid> Handle(CreateMainUserCommand request, CancellationToken cancellationToken)
        {
            if(string.IsNullOrEmpty(request.Name))
            {
                throw new CustomException("Name cannot be empty.");
            }

            var userId = Guid.NewGuid();
            Console.WriteLine($"User Created: ID = {userId}, Name = {request.Name}, Email = {request.Email}");
            return Task.FromResult(userId);
        }
    }
}