using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.TaskManagementSystem
{
    public class TaskRepository : ITaskRepository
    {
        private readonly string _connectionString;
        public TaskRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IEnumerable<TaskItem> GetAllTasks()
        {
            return new List<TaskItem> {
                new TaskItem { Id = 1, Description = "Task 1", IsCompleted = false },
                new TaskItem { Id = 2, Description = "Task 2", IsCompleted = true },
                new TaskItem { Id = 3, Description = "Task 3", IsCompleted = false }
            };
        }
    }
}