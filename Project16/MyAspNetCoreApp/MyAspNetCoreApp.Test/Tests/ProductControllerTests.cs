using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyAspNetCoreApp.Data;

namespace MyAspNetCoreApp.Test.Tests
{
    public class ProductControllerTests:IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;

        public ProductControllerTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory.WithWebHostBuilder(builder=>{
                builder.ConfigureServices(services=>{
                    var serviceProvider = new ServiceCollection()
                    .AddEntityFrameworkInMemoryDatabase()
                    .BuildServiceProvider();

                    services.AddDbContext<AppDbContext>(options=>{
                        options.UseInMemoryDatabase("TestDb");
                        options.UseInternalServiceProvider(serviceProvider);
                    });
                });
            });
        }

        [Fact]
        public async Task TestName()
        {
           var client = _factory.CreateClient();
           var response = await client.GetAsync("/api/Products");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            var products = await response.Content.ReadFromJsonAsync<Product[]>();
            Assert.NotNull(products);
            Assert.Empty(products);
        }
    }

   
}