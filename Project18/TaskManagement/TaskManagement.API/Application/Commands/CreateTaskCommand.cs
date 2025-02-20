using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using TaskManagement.API.Application.DTOs;

namespace TaskManagement.API.Application.Commands
{
    public class CreateTaskCommand:IRequest<TaskDto>
    {
        public string Title {get; set;}
        public string Description {get; set;}
        public DateTime DueDate {get; set;}   
    }
}