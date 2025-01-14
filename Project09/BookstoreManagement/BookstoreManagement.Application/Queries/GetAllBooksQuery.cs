using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagement.Application.DTOs;
using MediatR;

namespace BookstoreManagement.Application.Queries
{
    public class GetAllBooksQuery:IRequest<List<BookDto>>
    {
        
    }
}