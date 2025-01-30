using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LINQDataBase02.Models;
using Microsoft.EntityFrameworkCore;

namespace LINQDataBase02.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Product> Products {get; set;}
        public DbSet<Category> Categories {get; set;}

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
    }
}