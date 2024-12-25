using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LINQDemoApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LINQDemoApp
{
    public class AppDbContext:DbContext
    {

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("LINQDemoDb");
        }
    }
}