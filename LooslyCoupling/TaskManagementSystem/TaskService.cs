using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.TaskManagementSystem
{
    public class TaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public IEnumerable<TaskItem> GetIncompleteTasks()
        {
            return _taskRepository.GetAllTasks().Where(t => !t.IsCompleted);
        }
    }
}