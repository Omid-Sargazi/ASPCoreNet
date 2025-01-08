using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using MiddlewareExamples02.Exceptions;
using MiddlewareExamples02.Models;
using MiddlewareExamples02.Requests;

namespace MiddlewareExamples02.Handlers
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, Guid>
    {
        private readonly IMapper _mapper;

        public AddProductCommandHandler(IMapper mapper)
        {
            _mapper = mapper;           
        }
        public Task<Guid> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            if(string.IsNullOrEmpty(request.Name))
            {
                throw new CustomException("Product name cannot be empty.");
            }

            var product = _mapper.Map<Product>(request);

            product.Id = Guid.NewGuid();
            Console.WriteLine($"Product Added: {product.Id}, Name = {product.Name}, Price = {product.Price}");
            return Task.FromResult(product.Id);
        }
    }
}