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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
            .HasKey(p => p.Id);

            modelBuilder.Entity<Product>()
            .Property(p =>p.Name)
            .IsRequired();

             modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .IsRequired();

            modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId);
        }
    }
}