using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MiddlewareExamples02.Exceptions;
using MiddlewareExamples02.Requests;

namespace MiddlewareExamples02.Handlers
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, bool>
    {


        public Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            if(request.Id==Guid.Empty)
            {
                throw new CustomException("Invalid user ID");
            }
            return Task.FromResult(true);
        }
    }
}