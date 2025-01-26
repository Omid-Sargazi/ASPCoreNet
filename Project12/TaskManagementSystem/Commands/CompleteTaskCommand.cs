using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementSystem.Commands
{
    public class CompleteTaskCommand:Command
    {
       public CompleteTaskCommand(string taskId)
       {
            TaskId = taskId;
       } 
    }
}