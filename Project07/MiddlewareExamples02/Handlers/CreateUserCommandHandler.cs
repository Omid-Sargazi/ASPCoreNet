using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MiddlewareExamples02.Exceptions;
using MiddlewareExamples02.Requests;

namespace MiddlewareExamples02.Handlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
    {
        public Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            if(request.Name=="admin")
            {
                throw new CustomException("Admin user cannot be created");
            }

            return Task.FromResult(Guid.NewGuid());
        }
    }
}