using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FluentAPIDataAnnotations.Models;
using Microsoft.EntityFrameworkCore;

namespace FluentAPIDataAnnotations.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Student> Students {get; set;}
        public DbSet<Course> Courses {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
            .HasKey(b => b.BookId); 
            modelBuilder.Entity<Book>()
            .Property(b => b.Title)
            .HasColumnName("BookTitle");
            modelBuilder.Entity<Book>()
            .Property(b => b.Title)
            .HasMaxLength(100);
            modelBuilder.Entity<Book>()
            .Property(b => b.Title)
            .IsRequired();

            modelBuilder.Entity<Book>()
            .HasIndex(b => new{b.Title, b.Author});

            modelBuilder.Entity<Book>()
            .Property(b => b.Author)
            .HasDefaultValue("Unknown");

            modelBuilder.Entity<Enrollment>()
            .HasKey(e => new {e.StudentId, e.CourseId});

            modelBuilder.Entity<Course>()
            .HasOne(c => c.Student)
            .WithMany(s => s.Courses)
            .HasForeignKey(c => c.StudentId);

            modelBuilder.Entity<Student>()
            .Property(s =>s.Age)
            .HasColumnType("int")
            .IsRequired()
            .HasAnnotation("Range", new RangeAttribute(1,100));
        }
    }
}