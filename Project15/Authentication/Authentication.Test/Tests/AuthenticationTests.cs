using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Authentication.API.Models;
using Microsoft.AspNetCore.Mvc.Testing;


namespace Authentication.Test.Tests
{
    public class AuthenticationTests:IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public AuthenticationTests(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }


        [Fact]
        public async Task SignUp_ShouldReturnSuccess()
        {

            var request = new SignUpRequest
            {
                Email = "test@example.com",
                Password = "Test123!",
                FirstName = "John",
                LastName = "Doe"
            };

            var response = await _client.PostAsync("/api/auth/sign-up", 
            new StringContent(JsonSerializer.Serialize(request),Encoding.UTF8,"application/json")
            );

            response.EnsureSuccessStatusCode();
        }


        [Fact]
        public async Task SignIn_ShouldReturnSuccess()
        {
            await SignUp_ShouldReturnSuccess();

            var request = new SignInRequest
            {
                Email = "test@example.com",
                Password = "Test123!",
                RememberMe = false
            };

            var response = await _client.PostAsync("/api/auth/sign-in",
                new StringContent(JsonSerializer.Serialize(request),Encoding.UTF8, "appliction/json")
            );

            response.EnsureSuccessStatusCode();
        }
    }
}