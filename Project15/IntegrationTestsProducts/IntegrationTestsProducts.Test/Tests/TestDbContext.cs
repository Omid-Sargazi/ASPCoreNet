using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegrationTestsProducts.API.Data;
using Microsoft.EntityFrameworkCore;

namespace IntegrationTestsProducts.Test.Tests
{
    public class TestDbContext : IDisposable
    {
        public AppDbContext Context {get;}

        public TestDbContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            Context = new AppDbContext(options);
        }
        public void Dispose()
        {
            Context.Database.EnsureDeleted();
            Context.Dispose();
        }
    }
}