using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLDemo.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<product> Products {get;set;}
        public DbSet<Category> Categories {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category{Id = 1, Name = "Electronics"},
                new Category {Id=2, Name = "Clothing"}
            );

            modelBuilder.Entity<product>().HasData(
                new product { Id = 1, Name = "Laptop", Description = "High-performance laptop", Price = 1299.99m, Stock = 10, CategoryId = 1 },
                new product { Id = 2, Name = "Smartphone", Description = "Latest smartphone", Price = 899.99m, Stock = 15, CategoryId = 1 },
                new product { Id = 3, Name = "T-Shirt", Description = "Cotton t-shirt", Price = 19.99m, Stock = 100, CategoryId = 2 }
            );
        }
    }
}