using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Test01.SqlServer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

        public DbSet<Person> People {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
    {
                optionsBuilder.UseSqlServer("Server=localhost;Database=TestDB;User Id=sa;Password=15935755Omid$@;");
    }
        }
    }
}