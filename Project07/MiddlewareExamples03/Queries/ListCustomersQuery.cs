using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MiddlewareExamples03.DTOs;

namespace MiddlewareExamples03.Queries
{
    public record ListCustomersQuery(int Page, int PageSize, string? SearchTerm):IRequest<PagedResult<CustomerDto>>;
}