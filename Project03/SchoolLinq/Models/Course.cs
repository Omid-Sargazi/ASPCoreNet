using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolLinq.Models
{
    public class Course
    {
         public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int Credits { get; set; }
        public List<Enrollment> Enrollments { get; set; } = new();
    }
}