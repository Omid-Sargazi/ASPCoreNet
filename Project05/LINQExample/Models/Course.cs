using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQExample.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; } = string.Empty;
        public int InstructorId { get; set; }

        // Navigation properties
        public Instructor Instructor { get; set; } = null!;
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}