using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Season4.Models;

namespace Season4.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<User> Users {get; set;}
        public DbSet<UserProfile> UserProfiles {get; set;}
        public DbSet<Book> Books {get; set;}
        public DbSet<Review> Reviews {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasOne(u => u.Profile)
            .WithOne(p => p.User)
            .HasForeignKey<UserProfile>(p => p.UserId);

            modelBuilder.Entity<Book>()
            .HasMany(b => b.Reviews)
            .WithOne(r => r.Book)
            .HasForeignKey(r => r.BookId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");
        }
    }
}