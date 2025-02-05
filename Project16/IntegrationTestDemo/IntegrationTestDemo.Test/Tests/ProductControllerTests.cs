using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;
using IntegrationTestDemo.Data;
using Microsoft.AspNetCore.Mvc.Testing;

namespace IntegrationTestDemo.Test.Tests
{
    public class ProductControllerTests:IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;

        public ProductControllerTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetProducts_ReturnsEmptyListInitially()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/api/Products");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            var products = await response.Content.ReadFromJsonAsync<Product[]>();
            Assert.NotNull(products);
            Assert.Empty(products);
    }

        [Fact]
        public async Task AddProduct_ReturnsCreatedResponse()
        {
                var client = _factory.CreateClient();
                var newProduct = new Product {Name = "Test Product"};

                var response = await client.PostAsJsonAsync("/api/Products", newProduct);

                Assert.Equal(HttpStatusCode.Created,response.StatusCode);
        }

    }
}