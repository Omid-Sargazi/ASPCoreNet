using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using MiddlewareExamples03.Commands;
using MiddlewareExamples03.Models;

namespace MiddlewareExamples03.Handlers
{
    public class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand, Guid>
    {

        private readonly IMapper _mapper;

        public AddCustomerCommandHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Task<Guid> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            if(string.IsNullOrWhiteSpace(request.FirstName)|| string.IsNullOrWhiteSpace(request.LastName))
            {
                throw new Exception("");
            }

            var customer = _mapper.Map<Customer>(request);
            customer.Id = Guid.NewGuid();
            Console.WriteLine($"Customer Added: {customer.Id}, Name = {customer.FirstName} {customer.LastName}, Email = {customer.Email}");
            return Task.FromResult(customer.Id);
        }
    }
}