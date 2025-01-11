using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Test01.SqlServer
{
    public class AppDbContext:DbContext
    {
        // public AppDbContext()
        // {
        // }

       public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

        public DbSet<Person> People {get; set;}
        public DbSet<Author> Authors {get; set;}
        public DbSet<Book> Books {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
        {
                optionsBuilder.UseSqlServer("Server=localhost;Database=TestDB;User Id=sa;Password=15935755Omid$@;");
        }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
            .HasMany(a=>a.Books).WithOne(b=>b.Author).HasForeignKey(b=>b.AuthorId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}