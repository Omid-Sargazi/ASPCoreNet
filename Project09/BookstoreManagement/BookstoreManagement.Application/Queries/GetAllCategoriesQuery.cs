using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagement.Domain.Entities;
using MediatR;

namespace BookstoreManagement.Application.Queries
{
    public class GetAllCategoriesQuery:IRequest<List<Category>>
    {
        
    }
}