using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;

namespace MyAspNetCoreApp.Test.Tests
{
    public class WeatherForecastControllerTests:IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _httpClient;

        public WeatherForecastControllerTests(WebApplicationFactory<Program> factory)
        {
            _httpClient = factory.CreateClient();
        }

        [Fact]
        public async Task Get_WeatherForecast_ReturnsSuccessStatusCode()
        {
            var response = await _httpClient.GetAsync("/weatherforecast");

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}