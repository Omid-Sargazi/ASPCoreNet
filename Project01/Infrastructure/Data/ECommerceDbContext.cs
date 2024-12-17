using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ECommerceDbContext:DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options):base(options){}

        public DbSet<Product> Products{ get; set; }
        public DbSet<Supplier> Suppliers{ get; set; }
        public DbSet<Review> Reviews{ get; set; }
    }
}