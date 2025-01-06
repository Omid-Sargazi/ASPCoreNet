using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitectureExample.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureExample.Infrastructure.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

        public DbSet<TaskItem> TaskItems {get; set;}
        public DbSet<User> Users {get; set;}
        public DbSet<Project> Projects {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TaskItem>()
            .HasKey(t=>t.Id);

            modelBuilder.Entity<User>()
            .HasKey(u=> u.Id);

            modelBuilder.Entity<Project>()
            .HasKey(p=>p.Id);
        }
    }
}