using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MiddlewareExamples02.Requests
{
    public record CreateOrderCommand(string CustomerName, string ProductName, int Quantity):IRequest<Guid>;
}