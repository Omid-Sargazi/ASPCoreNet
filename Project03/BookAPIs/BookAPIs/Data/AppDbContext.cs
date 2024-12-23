using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAPIs.Models;
using Microsoft.EntityFrameworkCore;

namespace BookAPIs.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
        public DbSet<Book> Books {get;set;}
        public DbSet<Author> Authors {get;set;}
        public DbSet<Genre> Genres {get;set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
            .HasOne(b=>b.Author)
            .WithMany(a=>a.Books)
            .HasForeignKey(b=>b.AuthorId);


            modelBuilder.Entity<Book>()
            .HasOne(b=>b.Genre)
            .WithMany(g=>g.Books)
            .HasForeignKey(b=>b.GenreId);

            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    Id=1,
                    Name="J.K. Rowling"
                },
                new Author
                {
                    Id=2,
                    Name="George R.R. Martin"
                }
            );


            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Fantasy" },
                new Genre { Id = 2, Name = "Science Fiction" }
            );


            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "Harry Potter and the Philosopher's Stone", AuthorId = 1, GenreId = 1 },
            new Book { Id = 2, Title = "A Game of Thrones", AuthorId = 2, GenreId = 1 }
            );



            base.OnModelCreating(modelBuilder);
        }
    }
}