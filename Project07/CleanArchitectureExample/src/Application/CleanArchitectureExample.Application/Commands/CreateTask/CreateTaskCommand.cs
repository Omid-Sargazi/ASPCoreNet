using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CleanArchitectureExample.Application.Commands.CreateTask
{
    public class CreateTaskCommand:IRequest<Guid>
    {
        public string Title {get;set;} = string.Empty;
        public string Description {get;set;} = string.Empty;
         public DateTime? DueDate { get; set; }
        public Guid UserId { get; set; }
        public Guid ProjectId { get; set; } 
    }
}