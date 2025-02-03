using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinqQueryWithSqlServer.Models;
using Microsoft.EntityFrameworkCore;

namespace LinqQueryWithSqlServer.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Student> Students {get; set;}
        public DbSet<Course> Courses {get; set;}
        public DbSet<Enrollment> Enrollments {get; set;}
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(s => s.StudentId);
            modelBuilder.Entity<Course>().HasKey(c => c.CourseId);
            modelBuilder.Entity<Enrollment>().HasKey(e => e.CourseId);

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