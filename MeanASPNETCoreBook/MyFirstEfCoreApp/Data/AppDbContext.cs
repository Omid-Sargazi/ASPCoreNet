using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFirstEfCoreApp.Model;

namespace MyFirstEfCoreApp.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Book> Books {get; set;}
        // public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=books.db");
        }
    }
}