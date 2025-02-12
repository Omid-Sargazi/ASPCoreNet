using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domin.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure
{
    public class ApplicationDbContext:DbContext, IApplicationDbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){}   
    }
}