using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementSystem.Commands
{
    public abstract class Command
    {
        public string TaskId { get; set; }
        public string TaskName { get; set; }
    }
}