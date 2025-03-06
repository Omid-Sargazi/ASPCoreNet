using System;
using System.Collections.Generic;
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
        }
    }
}