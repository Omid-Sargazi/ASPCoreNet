using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyApp.Domain.Entities;
namespace MyApp.Infrastructure.Persistence
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Product> Products {get;set;}
        public DbSet<Category> Categories {get;set;}
        public DbSet<Order> Orders {get;set;}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){}
    }
}