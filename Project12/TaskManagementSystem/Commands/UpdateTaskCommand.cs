using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementSystem.Commands
{
    public class UpdateTaskCommand:Command
    {
        public string NewtaskName { get; set; }//update Task Name
        public string NewDescription { get; set; }//update Desription

        public UpdateTaskCommand(string taskId, string newTaskName, string newDescription)
        {
            TaskId = taskId;
            NewtaskName = newTaskName;
            NewDescription = newDescription;
        }
    }
}