using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegrationProductsTest.API.Data;
using Microsoft.EntityFrameworkCore;

namespace IntegrationProductsTest.Test.Tests
{
    public class TestDbContext : IDisposable
    {
        public ApplicationDbContext Context {get;}

        public TestDbContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            Context = new ApplicationDbContext(options);
        }
        public void Dispose()
        {
            Context.Database.EnsureDeleted();
            Context.Dispose();
        }
    }
}