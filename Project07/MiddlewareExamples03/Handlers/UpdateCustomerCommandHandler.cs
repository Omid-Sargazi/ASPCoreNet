using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MiddlewareExamples03.Queries;

namespace MiddlewareExamples03.Handlers
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, bool>
    {


        public Task<bool> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            if(request.Id==Guid.Empty)
            {
                throw new Exception("");
            }

             Console.WriteLine($"Customer Updated: ID = {request.Id}, Name = {request.FirstName} {request.LastName}, Email = {request.Email}");
        return Task.FromResult(true);
        }
    }
}