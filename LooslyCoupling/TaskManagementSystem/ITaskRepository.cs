using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.TaskManagementSystem
{
    public interface ITaskRepository
    {
        public IEnumerable<TaskItem> GetAllTasks();
    }
}