using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RestfullAPIs.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

        public DbSet<Book> Books {get;set;}
        public DbSet<Author> Authors {get;set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>()
            .HasOne(b=>b.Author).WithMany(a=>a.Books)
            .HasForeignKey(b=>b.AuthorId);



            modelBuilder.Entity<Author>().HasData(
            new Author { Id = 1, Name = "John Doe" },
            new Author { Id = 2, Name = "Jane Smith" }
            );



            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "C# Basics", AuthorId = 1 },
            new Book { Id = 2, Title = "ASP.NET Core", AuthorId = 2 }
            );
        }
    }
}