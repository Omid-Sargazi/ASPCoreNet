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
    public class AuthenticationTests02:IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public AuthenticationTests02(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        private async Task CreateTestUserAsync()
        {
            var request = new SignUpRequest
            {
                 Email = "test@example.com",
                Password = "Test@123!",
                FirstName = "John",
                LastName = "Doe"
            };

            await _client.PostAsync("/api/auth/sign-up",
                new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8,"application/json")
            );
        }


        [Fact]
        public async Task SignUp_ShouldReturnSuccess()
        {
            await CreateTestUserAsync();
        }

        // [Fact]
        public async Task SignIn_ShouldReturnSuccess()
        {
            await CreateTestUserAsync(); // ensure the user exist.

            var request = new SignInRequest
            {
                Email = "test@example.com",
                Password = "Test123!",
                RememberMe = false
            };

            var response = await _client.PostAsync("/api/auth/sign-in",
                new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json")
            );
            response.EnsureSuccessStatusCode();
        }
    }
}