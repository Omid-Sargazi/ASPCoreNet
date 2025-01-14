using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace BookstoreManagement.Application.Commands.Author
{
    public class DeleteAuthorCommand:IRequest
    {
        public int Id {get; set;}
    }
}