using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryForQUery.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryForQUery
{
    public class SchoolContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author> Authors {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("LibrrayDb");
        }
    }
}