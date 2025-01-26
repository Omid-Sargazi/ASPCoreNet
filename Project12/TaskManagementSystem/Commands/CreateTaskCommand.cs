using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementSystem.Commands
{
    public class CreateTaskCommand:Command
    {
        public string Description { get; set; }

        public CreateTaskCommand(string taskName, string description)
        {
            TaskId = Guid.NewGuid().ToString();
            TaskName = taskName;
            Description = description;
        }
    }
}