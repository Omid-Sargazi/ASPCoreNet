using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Season4.Models
{
    public class Student
    {
        public int StudentId {get; set;}
        public string Name {get; set;}

        public List<Course> Courses {get; set;} = new();
    }
}