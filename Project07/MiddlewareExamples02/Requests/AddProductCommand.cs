using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MiddlewareExamples02.Requests
{
    public record AddProductCommand(string Name, int Price):IRequest<Guid>;
}