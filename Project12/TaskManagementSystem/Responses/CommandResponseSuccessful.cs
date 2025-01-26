using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementSystem.Responses
{
    public class CommandResponseSuccessful:CommandResponse
    {
        public CommandResponseSuccessful(string taskId, string taskName, string message="Operation Successful")
        {
            TaskId = taskId;
            TaskName = taskName;
            Status = "Success";
            Message = message;
        }

        public static CommandResponse CreateSuccessful(string taskId, string taskName, string message = "Operation Successful")
        {
            return new CommandResponseSuccessful(taskId, taskName, message);
        }
    }
}