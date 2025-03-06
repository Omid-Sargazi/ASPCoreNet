using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FluentAPIDataAnnotations.Models
{
    public class Enrollment
    {
        [Key,Column(Order =0)]
        public int StudentId {get; set;}
        [Key, Column(Order =1)]
        public int CourseId {get; set;}
        public DateTime EnrollmentDate {get; set;}
    }
}