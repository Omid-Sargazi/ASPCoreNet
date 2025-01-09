using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MiddlewareExamples03.Queries
{
    public class UpdateCustomerCommand(Guid Id, string FirstName, string LastName, string Email, string Phone):IRequest<bool>;
}