using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DayEightOfBook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DayEightOfBook.Data
{
    public class AppDbContext:IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}

        public DbSet<Product> Products {get; set;}
    }

 
}