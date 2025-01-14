using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace BookstoreManagement.Application.Commands.Category
{
    public class UpdateCategoryCommand:IRequest
    {
        public int Id {get; set;}
        public string Name {get;set;}
    }
}