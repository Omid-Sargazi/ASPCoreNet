using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQExample.Models
{
    public class Enrollment
    {
         public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        // Navigation properties
        public Student Student { get; set; } = null!;
        public Course Course { get; set; } = null!;
    }
}