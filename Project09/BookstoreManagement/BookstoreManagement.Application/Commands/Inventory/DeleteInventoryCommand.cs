using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace BookstoreManagement.Application.Commands.Inventory
{
    public class DeleteInventoryCommand:IRequest<Unit>
    {
        public int Id {get; set;}
    }
}