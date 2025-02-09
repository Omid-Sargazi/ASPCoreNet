using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegrationTests.API.Data;
using IntegrationTests.API.Interfaces;
using IntegrationTests.API.Models;
using IntegrationTests.API.Services;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace IntegrationTests.Test.Tests
{
    public class OrderServiceIntegrationTests:IClassFixture<WebApplicationFactory<Program>>
    {
        public readonly WebApplicationFactory<Program> _factory;
        private  HttpClient _client;
        private  Mock<IPaymentGateway> _mockPaymentGateway;


        public OrderServiceIntegrationTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory.WithWebHostBuilder(builder =>{
                builder.ConfigureServices(services=>{
                    services.AddDbContext<AppDbContext>(options=>{
                        options.UseInMemoryDatabase("Testdb");
                    });

                    _mockPaymentGateway = new Mock<IPaymentGateway>();

                });

                _client = _factory.CreateClient();
            });
        }


        public async Task ProcessOrderAsync_ShouldProcessPaymentAndUpdateOrderStatus()
        {
            var order = new Order{Id = 1, TotalAmount = 100.0m, IsPaid = false};

            using(var scope = _factory.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                dbContext.Orders.Add(order);
                await dbContext.SaveChangesAsync();
            }

            _mockPaymentGateway.Setup(x => x.ProcessPaymentAsync(It.IsAny<decimal>())).ReturnsAsync(true);


            using (var scope = _factory.Services.CreateScope())
        {
            var orderService = scope.ServiceProvider.GetRequiredService<OrderService>();
            var result = await orderService.ProcessOrderAsync(1);
        }

        // Assert
        using (var scope = _factory.Services.CreateScope())
        {
            var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            var updatedOrder = await dbContext.Orders.FindAsync(1);

            Assert.True(updatedOrder.IsPaid);
        }

        _mockPaymentGateway.Verify(x => x.ProcessPaymentAsync(100.0m), Times.Once);
        }
    }
}