using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FluentAPIDataAnnotations.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
        [Range(1,100)]
        public int Age {get; set;}
    }
}