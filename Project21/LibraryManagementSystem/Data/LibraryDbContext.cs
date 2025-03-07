using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace LibraryManagementSystem.Data
{
    public class LibraryDbContext:DbContext
    {
        public DbSet<Book> Books {get; set;}
        public DbSet<Category> Categories {get; set;}
        public DbSet<Review> Reviews {get; set;}
        public DbSet<User> Users {get; set;}
        public DbSet<BorrowTransaction> BorrowTransactions {get; set;}

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options):base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("Books");
                entity.HasKey(b=>b.Id);
                entity.Property(b => b.ISBN).IsRequired().HasMaxLength(13);
                entity.Property(b => b.Title).IsRequired().HasMaxLength(250);
                entity.Property(b => b.Author).IsRequired().HasMaxLength(150);
                entity.Property(b => b.Publisher).HasMaxLength(100);
                entity.Property(b => b.Price).HasColumnType("decimal(18,2)");
                entity.Property(b => b.Description).HasMaxLength(2000);
                entity.Property(b => b.RowVersion).IsRowVersion();
            });

        }

    }
}