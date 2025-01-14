using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace BookstoreManagement.Application.Commands.Inventory
{
    public class AddInventoryCommand:IRequest<int>
    {
        public int BookId {get;set;}
        public int Quantity {get;set;}
    }
}