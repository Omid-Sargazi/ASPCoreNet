using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DayTwoOfEntityFrameWork.Models;
using Microsoft.EntityFrameworkCore;

namespace DayTwoOfEntityFrameWork.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Book> Books {get; set;}
        public DbSet<Author> Authors {get; set;}
        public DbSet<Review> Reviews {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = app.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author {AuthorId = 1, Name = "Omid"},
                new Author {AuthorId = 2, Name = "Saeed"}
            );
            modelBuilder.Entity<Book>().HasData(
                new Book {BookId = 1, Title = "C# Programming", AuthorId = 1},
                new Book {BookId = 2, Title = "Advanced EF Core", AuthorId = 1},
                new Book {BookId = 3, Title = "EF Core for Beginners", AuthorId = 2}

            );

            modelBuilder.Entity<Review>().HasData(
                new Review {ReviewId = 1, Comment = "Great Book", BookId = 1},
                new Review {ReviewId = 2, Comment = "I love it", BookId = 1},
                new Review {ReviewId = 3, Comment = "Very helpful.", BookId = 1},
                new Review {ReviewId = 4, Comment = "Great Book", BookId = 2},
                new Review {ReviewId = 5, Comment = "Excellent resource", BookId = 3}
            );
        }
    }
}