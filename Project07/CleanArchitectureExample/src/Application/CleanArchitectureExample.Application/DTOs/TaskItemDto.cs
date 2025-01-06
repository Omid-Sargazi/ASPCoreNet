using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitectureExample.Application.DTOs
{
    public class TaskItemDto
    {
       public Guid Id {get;set;}
       public string Title {get;set;} = string.Empty;
       public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime? DueDate { get; set; }
        public Guid UserId { get; set; }
        public Guid ProjectId { get; set; }
    }
}