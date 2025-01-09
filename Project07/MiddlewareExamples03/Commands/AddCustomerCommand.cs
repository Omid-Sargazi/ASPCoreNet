using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MiddlewareExamples03.Commands
{
    public record AddCustomerCommand(string FirstName, string LastName, string Email, string Phone):IRequest<Guid>;
}