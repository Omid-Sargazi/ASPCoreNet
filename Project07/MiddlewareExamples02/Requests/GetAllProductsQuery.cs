using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MiddlewareExamples02.Models;

namespace MiddlewareExamples02.Requests
{
    public record GetAllProductsQuery():IRequest<List<ProductDto>>;
}