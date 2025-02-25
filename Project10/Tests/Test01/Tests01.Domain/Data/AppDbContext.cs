using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tests01.Domain.Models;

namespace Tests01.Domain.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

        public DbSet<Book> Books {get; set;}
        public DbSet<Author> Authors {get; set;}
    }
}