using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagement.Application.DTOs;
using MediatR;

namespace BookstoreManagement.Application.Queries
{
    public class GetInventoryQuery:IRequest<InventoryDto>
    {
        public int Id {get; set;}
    }
}