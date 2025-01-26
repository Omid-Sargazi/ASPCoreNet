using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementSystem.Responses
{
    public class CommandResponseFailed:CommandResponse
    {
        public CommandResponseFailed(string taskId, string taskName, string message="Operation Failed")
        {
            TaskId = taskId;
            TaskName = taskName;
            Status = "Failed";
            Message = message;
        }

        public static CommandResponse CreateFailed(string taskId, string taskName, string message = "Operation Failed")
        {
            return new CommandResponseFailed(taskId, taskName, message);
        }
    }
}