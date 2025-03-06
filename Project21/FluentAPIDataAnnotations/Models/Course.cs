using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentAPIDataAnnotations.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}