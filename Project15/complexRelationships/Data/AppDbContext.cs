using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using complexRelationships.models;
using Microsoft.EntityFrameworkCore;

namespace complexRelationships.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Book> Books {get; set;}
        public DbSet<Author> Authors {get; set;}
        public DbSet<Category> Categories {get; set;}
        public DbSet<BookCategory> BookCategories {get; set;}
        public DbSet<AuthorContact> AuthorContacts {get; set;}

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer("DafaultConnectionString");
        // }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
            .HasOne(a => a.Contact)
            .WithOne(c =>c.Author)
            .HasForeignKey<AuthorContact>(c => c.AuthorId);

            modelBuilder.Entity<BookCategory>()
            .HasKey(bc => new {bc.BookId, bc.CategoryId});

            modelBuilder.Entity<BookCategory>()
            .HasOne(bc => bc.Book)
            .WithMany(b =>b.BookCategories)
            .HasForeignKey(bc => bc.BookId);

            modelBuilder.Entity<BookCategory>()
            .HasOne(bc => bc.Category)
            .WithMany(c => c.BookCategories)
            .HasForeignKey(bc => bc.CategoryId);
        }
    }
}