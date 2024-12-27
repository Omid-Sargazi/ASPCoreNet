using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibaryWithQueries.Models;
using Microsoft.EntityFrameworkCore;

namespace LibaryWithQueries
{
    public class ApplicationDbContext:DbContext
    {
         public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("LibraryDatabase");
        }
    }
}