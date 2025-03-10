using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreAPIs.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreAPIs.Data
{
    public class BookStoreContext:DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options):base(options){}
        DbSet<Book> Books {get; set;}
        DbSet<Author> Authors {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
            .HasOne(b => b.Author)
            .WithMany(a => a.Books)
            .HasForeignKey(b=>b.AuthorId);

            modelBuilder.Entity<Book>()
            .HasIndex(b => b.ISBN)
            .IsUnique();

            modelBuilder.Entity<Book>()
            .Property(b => b.IsAvailable)
            .HasDefaultValue(true);
        }
    }
}