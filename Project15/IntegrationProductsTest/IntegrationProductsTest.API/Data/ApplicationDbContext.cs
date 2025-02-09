using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegrationProductsTest.API.Models;
using Microsoft.EntityFrameworkCore;

namespace IntegrationProductsTest.API.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Category> Categories {get; set;}
        public DbSet<Product> Products {get; set;}
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){}
    }
}