using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyAspNetCoreApp.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Product> Products {get; set;}
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
    }
}