using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskManagementSystem.Responses
{
    public abstract class CommandResponse
    {
        public CommandResponse()
        {
            Status = "Pending";
        }

        public CommandResponse(string taskId, string taskName, string status)
        {
            TaskId = taskId;
            TaskName = taskName;
            Status = status;            
        }

        public string TaskId { get; set; }
        public string TaskName { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
    }
}