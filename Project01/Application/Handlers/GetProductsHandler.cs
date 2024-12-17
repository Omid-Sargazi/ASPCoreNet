using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.Products;
using Core.Entities;
using Core.Interfaces;
using MediatR;

namespace Application.Handlers
{
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {
        private readonly IRepository<Product> _repository;

        public GetProductsHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync();
        }
    }
}