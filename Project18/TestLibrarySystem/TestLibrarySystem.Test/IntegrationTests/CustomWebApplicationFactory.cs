using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestLibrarySystem.API.Data;
using TestLibrarySystem.API.Models;

namespace TestLibrarySystem.Test.IntegrationTests
{
    public class CustomWebApplicationFactory:WebApplicationFactory<Program>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services=>{
                var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<LibraryDbContext>));
                if(descriptor != null)
                {
                    services.Remove(descriptor);
                }

                services.AddDbContext<LibraryDbContext>(options => options.UseInMemoryDatabase("testDb"));

                var sp = services.BuildServiceProvider();
                using var scope = sp.CreateAsyncScope();
                var db = scope.ServiceProvider.GetRequiredService<LibraryDbContext>();
                db.Database.EnsureCreated();
                SeedData(db);
                
            });
        }

        private void SeedData(LibraryDbContext db)
        {
            db.Books.AddRange(
                new  Book { Id = 1, Title = "Test Book 1", Author = "Author 1", Price = 10.99m },
                new  Book { Id = 2, Title = "Test Book 2", Author = "Author 2", Price = 15.99m }
            );

            db.SaveChanges();
        }
    }
}