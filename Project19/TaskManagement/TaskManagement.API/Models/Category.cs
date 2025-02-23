using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagement.API.Models
{
    public class Category
    {
        public int Id { get; set; }
         public string Name { get; set; }
         public List<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
}