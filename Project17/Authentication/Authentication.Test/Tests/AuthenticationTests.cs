using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Authentication.API.Models;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Authentication.Test.Tests
{
    public class AuthenticationTests:IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _httpClient;

        public AuthenticationTests(WebApplicationFactory<Program> factory)
        {
            _httpClient = factory.CreateClient();
        }

        [Fact]
        public async Task SignUp_ShouldReturnSuccess()
        {
            var request = new SignUpRequest
            {
                Email = "test@example.com",
                Password = "Test@123",
                FirstName = "John",
                LastName = "Doe",
            };

            var response = await _httpClient.PostAsync("/api/auth/sign-up", 
            new StringContent(JsonSerializer.Serialize(request),Encoding.UTF8,"application/json"));

            response.EnsureSuccessStatusCode();

        }
    }
}