using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using MiddlewareExamples02.Models;
using MiddlewareExamples02.Requests;

namespace MiddlewareExamples02.Handlers
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<ProductDto>>
    {
        private readonly IMapper _mapper;

        public GetAllProductsQueryHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        public Task<List<ProductDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = new List<Product>
        {
            new Product { Id = Guid.NewGuid(), Name = "Laptop", Price = 999.99m },
            new Product { Id = Guid.NewGuid(), Name = "Phone", Price = 499.99m }
        };

        var productDtos = _mapper.Map<List<ProductDto>>(products);
        Console.WriteLine("Products Retrieved:");
        productDtos.ForEach(p => Console.WriteLine($"ID: {p.Id}, Name: {p.Name}, Price: {p.Price}"));
        return Task.FromResult(productDtos);
        }
    }
}