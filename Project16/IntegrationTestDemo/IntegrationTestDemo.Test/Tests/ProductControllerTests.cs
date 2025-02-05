using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;
using IntegrationTestDemo.Data;
using IntegrationTestDemo.Services;
using Microsoft.AspNetCore.Mvc.Testing;
using Moq;

namespace IntegrationTestDemo.Test.Tests
{
    public class ProductControllerTests:IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;
        private readonly Mock<IProductService> _mockService;

        public ProductControllerTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
            _mockService = new Mock<IProductService>();

        }

        [Fact]
        public async Task GetProducts_ReturnsEmptyListInitially()
        {
            _mockService.Setup(s => s.GetAllProductsAsync()).ReturnsAsync(new List<Product> {new Product {Id=1, Name="Test Product"}});
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/api/Products");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            var products = await response.Content.ReadFromJsonAsync<List<Product>>();
            Assert.NotNull(products);
            Assert.Single(products);
            Assert.Equal("Test Product", products[0].Name);
            // Assert.Empty(products);
    }

       [Fact]
        public async Task AddProduct_ReturnsCreatedResponse()
        {
                var newProduct = new Product {Id = 1, Name = "Mocked Product"};
                _mockService.Setup(s => s.AddProductAsync(It.IsAny<Product>())).Returns(Task.CompletedTask);
                var client = _factory.CreateClient();

                var response = await client.PostAsJsonAsync("/api/Products", newProduct);

                Assert.Equal(HttpStatusCode.Created,response.StatusCode);
        }

    }
}