using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MiddlewareExamples02.Exceptions;
using MiddlewareExamples02.Requests;

namespace MiddlewareExamples02.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, bool>
{
    public Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        if (request.Id == Guid.Empty)
        {
            throw new CustomException("Invalid Product ID.");
        }

        // Simulate product update
        Console.WriteLine($"Product Updated: ID = {request.Id}, Name = {request.Name}, Price = {request.Price}");
        return Task.FromResult(true);
    }
}

}