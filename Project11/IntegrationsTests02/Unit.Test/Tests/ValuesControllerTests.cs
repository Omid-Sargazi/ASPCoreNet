using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Unit.Test.Tests
{
    public class ValuesControllerTests:IClassFixture<WebApplicationFactory<Progarm>>
    {
        private readonly HttpClient _client;

        public ValuesControllerTests(WebApplicationFactory<Progarm> factory)
        {
            _client = factory.CreateClient();
        }

        //[Fact]
        public async Task Get_ReturnsExpectedResponse()
        {
            var response = await _client.GetAsync("/api/values");
            var content = await response.Content.ReadAsStringAsync();
            Assert.Equal("[\"value1\",\"value2\"]", content);
        }

        //[Fact]
        public async Task Get_ReturnsSuccessStatusCode()
        {
            var response = await _client.GetAsync("/api/values");

            response.EnsureSuccessStatusCode();
        }

        //[Fact]
        public async Task Post_ReturnsCreatedStatusCode()
        {
            var content = new StringContent("\"omid\"", Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("/api/values", content);

            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        }
    }
}