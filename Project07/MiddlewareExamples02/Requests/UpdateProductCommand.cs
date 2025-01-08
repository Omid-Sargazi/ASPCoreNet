using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MiddlewareExamples02.Requests
{
    public record UpdateProductCommand(Guid Id, string Name, string Price):IRequest<bool>;
}