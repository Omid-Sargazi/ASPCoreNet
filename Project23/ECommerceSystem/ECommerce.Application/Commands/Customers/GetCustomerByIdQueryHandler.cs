using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ECommerce.Application.DTOs;
using ECommerce.Domain.Entities;
using ECommerce.Domain.Interfaces;
using MediatR;

namespace ECommerce.Application.Commands.Customers
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, CustomerDto>
    {
        private readonly IRepository<Customer> _customerRepository;
        private readonly IMapper _mapper;

        public GetCustomerByIdQueryHandler(IRepository<Customer> repository, IMapper mapper)
        {
            _customerRepository = repository;
            _mapper = mapper;
        }
        public async Task<CustomerDto> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetByIdAsync(request.Id);
            return _mapper.Map<CustomerDto>(customer);
        }
    }
}