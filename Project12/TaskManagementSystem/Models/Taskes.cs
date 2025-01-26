using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementSystem.Models
{
    public class Taskes
    {
        public string TaskId { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}