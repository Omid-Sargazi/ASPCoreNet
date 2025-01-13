using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BookstoreManagement.Infrastructure.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            optionBuilder.UseSqlServer("Server=localhost; Database=BookStore; Trusted_Connection=False; User Id=sa; Password=15935755Omid$@; TrustServerCertificate=True; Encrypt=False;");

            return new ApplicationDbContext(optionBuilder.Options);
        }
    }
}