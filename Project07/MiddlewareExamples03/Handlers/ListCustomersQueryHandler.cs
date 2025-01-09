using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using MiddlewareExamples03.DTOs;
using MiddlewareExamples03.Models;
using MiddlewareExamples03.Queries;

namespace MiddlewareExamples03.Handlers
{
    public class ListCustomersQueryHandler : IRequestHandler<ListCustomersQuery, PagedResult<CustomerDto>>
    {

        private readonly IMapper _mapper;

        public ListCustomersQueryHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        public Task<PagedResult<CustomerDto>> Handle(ListCustomersQuery request, CancellationToken cancellationToken)
        {
            var customers = new List<Customer>
            {
                new Customer { Id = Guid.NewGuid(), FirstName = "Alice", LastName = "Smith", Email = "alice.smith@example.com", Phone = "+1234567890" },
                new Customer { Id = Guid.NewGuid(), FirstName = "Bob", LastName = "Johnson", Email = "bob.johnson@example.com", Phone = "+1987654321" },
                new Customer { Id = Guid.NewGuid(), FirstName = "Charlie", LastName = "Brown", Email = "charlie.brown@example.com", Phone = "+1122334455" }
            };



            if (!string.IsNullOrWhiteSpace(request.SearchTerm))
            {
                customers = customers.Where(c => 
                    c.FirstName.Contains(request.SearchTerm, StringComparison.OrdinalIgnoreCase) || 
                    c.LastName.Contains(request.SearchTerm, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            // Paginate
            var pagedCustomers = customers
                .Skip((request.Page - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToList();

            var customerDtos = _mapper.Map<List<CustomerDto>>(pagedCustomers);

            return Task.FromResult(new PagedResult<CustomerDto>
            {
                Items = customerDtos,
                TotalCount = customers.Count
            });
        }
    }
}