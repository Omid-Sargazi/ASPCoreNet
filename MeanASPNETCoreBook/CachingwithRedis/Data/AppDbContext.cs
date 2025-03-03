using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CachingwithRedis.Model;
using CachingwithRedis.Models;
using Microsoft.EntityFrameworkCore;

namespace CachingwithRedis.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }  
        public DbSet<Order> Orders { get; set; } 
        
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
        
    }
}