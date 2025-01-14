using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace BookstoreManagement.Application.Commands.Inventory
{
    public class UpdateInventoryCommand:IRequest
    {
        public int Id {get; set;}
        public int Quantity {get; set;}
    }
}