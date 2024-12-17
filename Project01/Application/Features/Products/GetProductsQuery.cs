using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using MediatR;

namespace Application.Features.Products
{
    public class GetProductsQuery:IRequest<IEnumerable<Product>>
    {
        
    }
}