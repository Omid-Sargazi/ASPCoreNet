using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Season4.Models
{
    public class Course
    {
        public int CourseId {get; set;}
        public string CourseName {get; set;}

        public List<Student> Students {get; set;} = new();
    }
}