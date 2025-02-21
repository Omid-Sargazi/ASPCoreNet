using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestLibrarySystem.API.Models;

namespace TestLibrarySystem.API.Data
{
    public class LibraryDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options):base(options)
        {
            
        }
    }
}