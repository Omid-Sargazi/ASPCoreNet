using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace BookstoreManagement.Application.Commands.Author
{
    public class AddAuthorCommand:IRequest<int>
    {
        public string Name {get; set}
    }
}