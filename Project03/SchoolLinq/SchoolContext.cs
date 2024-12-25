using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolLinq.Models;

namespace SchoolLinq
{
    public class SchoolContext:DbContext
    {
        DbSet<Student> Students {get;set;}
        DbSet<Enrollment> Enrollments {get;set;}
        DbSet<Course> Courses {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("SchoolDb");
        }
    }
}