using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegrationTestsProducts.API.Models;
using Microsoft.EntityFrameworkCore;

namespace IntegrationTestsProducts.API.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Category> Categories {get; set;}
        public DbSet<Product> Products {get; set;}

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

    }
}