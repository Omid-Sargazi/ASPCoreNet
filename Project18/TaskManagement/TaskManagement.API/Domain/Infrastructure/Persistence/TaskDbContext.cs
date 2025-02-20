using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TaskManagement.API.Domain.Entities;

namespace TaskManagement.API.Domain.Infrastructure.Persistence
{
    public class TaskDbContext:DbContext
    {
        public DbSet<Tassk> Tassks {get; set;}   

        public TaskDbContext(DbContextOptions<TaskDbContext> options):base(options)
        {
            
        }
    }
}