using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderManagement.Models;

namespace OrderManagement.Data
{
    public class OrderDbContext:DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products {get;set;}
        public DbSet<OrderDetail> OrderDetails {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=orders.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<OrderDetail>()
            .HasKey(od=>new {od.OrderId,od.ProductId});


            modelBuilder.Entity<OrderDetail>()
            .HasOne(od=>od.Order)
            .WithMany(o=>o.orderDetails)
            .HasForeignKey(od=>od.OrderId);


            modelBuilder.Entity<OrderDetail>()
            .HasOne(od=>od.Product)
            .WithMany(p=>p.orderDetails)
            .HasForeignKey(od=>od.ProductId);
        }
    }
}