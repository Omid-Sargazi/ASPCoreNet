using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LINQExample.Models;
using Microsoft.EntityFrameworkCore;

namespace LINQExample
{
    public class SchoolContext: DbContext
    {
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Instructor> Instructors { get; set; } = null!;
        public DbSet<Course> Courses { get; set; } = null!;
        public DbSet<Enrollment> Enrollments { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=school.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Enrollment>().HasKey(e=>e.EnrollmentId);

             modelBuilder.Entity<Enrollment>()
            .HasOne(e => e.Student)
            .WithMany(s => s.Enrollments)
            .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Enrollment>()
            .HasOne(e => e.Course)
            .WithMany(c => c.Enrollments)
            .HasForeignKey(e => e.CourseId);

            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, Name = "John Doe" },
                new Student { StudentId = 2, Name = "Jane Doe" }
            );

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor { InstructorId = 1, Name = "Dr. Smith" },
                new Instructor { InstructorId = 2, Name = "Dr. Johnson" }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 1, Title = "Math 101", InstructorId = 1 },
                new Course { CourseId = 2, Title = "English 101", InstructorId = 2 }
            );

            modelBuilder.Entity<Enrollment>().HasData(
                new Enrollment { EnrollmentId = 1, StudentId = 1, CourseId = 1 },
                new Enrollment { EnrollmentId = 2, StudentId = 2, CourseId = 2 }
            );
        }
    }
}