using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQExample.Models
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string Name { get; set; } = string.Empty;

        // Navigation property
        public ICollection<Course> Courses { get; set; } = new List<Course>();
        }
}