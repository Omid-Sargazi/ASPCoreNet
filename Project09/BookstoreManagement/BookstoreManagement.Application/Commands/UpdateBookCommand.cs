using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace BookstoreManagement.Application.Commands
{
    public class UpdateBookCommand:IRequest<Unit>
    {
        public int Id {get;set}
        public string Title {get; set;}
        public decimal Price {get;set}
        public int AuthorId {get; set;}
        public int CategoryId {get;set }
    }
}