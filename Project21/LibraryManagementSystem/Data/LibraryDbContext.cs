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

                entity.HasIndex(b => b.ISBN).IsUnique();
            });

            modelBuilder.Entity<Category>(entity=>{
                entity.ToTable("Categories");
                entity.HasKey(b => b.Id);
                entity.Property(c => c.Name).IsRequired().HasMaxLength(50);
                entity.Property(c => c.Description).HasMaxLength(500);

                entity.HasIndex(c => c.Name).IsUnique();
            });

            modelBuilder.Entity<BookCategory>(entity=> {
                entity.ToTable("BookCategories");
                entity.HasKey(bc => new {bc.BookId, bc.CategoryId});
                
                entity.HasOne(bc => bc.Book)
                .WithMany(b => b.BookCategories)
                .HasForeignKey(bc => bc.BookId);

                entity.HasOne(bc => bc.Category)
                .WithMany(bc => bc.BookCategories)
                .HasForeignKey(bc => bc.CategoryId);
            });

            modelBuilder.Entity<Review>(entity=>{
                entity.ToTable("Reviews");
                entity.HasKey(r => r.Id);
                entity.Property(r => r.Rating).IsRequired();
                entity.Property(r => r.Comment).HasMaxLength(1000);
                entity.Property(r => r.CreatedAt).HasDefaultValueSql("GETDATA()");

                entity.HasOne(r =>r.Book)
                .WithMany(b => b.Reviews)
                .HasForeignKey(r => r.BookId)
                .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<User>(entity => {
                entity.ToTable("User");
                entity.HasKey(u => u.Id);
                entity.Property(u => u.FirstName).IsRequired().HasMaxLength(50);
                entity.Property(u => u.LastName).IsRequired().HasMaxLength(50);
                entity.Property(u => u.Email).IsRequired().HasMaxLength(50);
                entity.Property(u => u.PhoneNumber).HasMaxLength(15);
                entity.Property(u => u.RegistrationDate).HasDefaultValueSql("GETDATE()");
                entity.Property(u => u.IsActive).HasDefaultValue(true);

                entity.OwnsOne(u => u.Address, address=>{
                    address.Property(a => a.Street).HasColumnName("Street").HasMaxLength(100);
                    address.Property(a => a.City).HasColumnName("City").HasMaxLength(50);
                    address.Property(a => a.State).HasColumnName("State").HasMaxLength(50);
                    address.Property(a => a.ZipCode).HasColumnName("ZipCode").HasMaxLength(10);
                    address.Property(a => a.Country).HasColumnName("ZipCode").HasMaxLength(50);
                });

                entity.HasIndex(u =>u.Email).IsUnique();
            });



        }

    }
}