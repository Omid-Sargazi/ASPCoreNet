using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeanASPNETCoreBook.API.Controllers;
using Microsoft.EntityFrameworkCore;

namespace MeanASPNETCoreBook.API.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
        public DbSet<Product> Products {get; set;}
    }
}