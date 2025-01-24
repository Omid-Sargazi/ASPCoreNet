using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Integration.API.Controllers;
using Microsoft.AspNetCore.Mvc.Testing;
using Integration.API;
using Xunit;

namespace Integration.Tests.Tests
{
    public class ValuesControllerTests:IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public ValuesControllerTests(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task Get_ReturnsSuccessStatusCode()
        {
            var response = await _client.GetAsync("/api/values");
            response.EnsureSuccessStatusCode();
            Assert.Equal("OK", response.StatusCode.ToString());
        }

        //[Fact]
        public void Add_TwoNumber()
        {
            int a = 3;
            int b = 5;

            int result = 8;

            Assert.Equal(80,result);
        }
    }


   
}