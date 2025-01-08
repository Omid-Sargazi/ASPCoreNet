using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MiddlewareExamples02.Exceptions;
using MiddlewareExamples02.Requests;

namespace MiddlewareExamples02.Handlers
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Guid>
    {

        public Task<Guid> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            if(request.Quantity <= 0)
            {
                throw new CustomException("Quantity must be greater than zero.");
            }

            var newOrderId = Guid.NewGuid();
            Console.WriteLine($"Order Created: ID = {newOrderId}");
            return Task.FromResult(newOrderId);
        }
    }
}