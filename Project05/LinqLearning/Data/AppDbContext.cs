using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinqLearning.Models;
using Microsoft.EntityFrameworkCore;

namespace LinqLearning.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=linqlearning.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasKey(s=>s.StudentId);
            modelBuilder.Entity<Course>().HasKey(c=>c.CourseId);
            modelBuilder.Entity<Enrollment>().HasKey(e=>e.EnrollmentId);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseId);
        }
    }
}