using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementSystem.Responses
{
    public class CommandResponseCanceled:CommandResponse
    {
        public CommandResponseCanceled(string taskId, string tsakName, string message="Operation Canceled")
        {
            TaskId = taskId;
            TaskName = tsakName;
            Status = "Canceled";
            Message = message;
        }

        public static CommandResponse CreateCanceled(string taskId, string taskName, string message = "Operation Canceled")
        {
            return new CommandResponseCanceled(taskId, taskName, message);
    }
}