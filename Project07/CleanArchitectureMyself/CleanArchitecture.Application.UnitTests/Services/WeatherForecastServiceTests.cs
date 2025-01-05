using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Infrastructure.Services;
using FluentAssertions;

namespace CleanArchitecture.Application.UnitTests.Services
{
    public class WeatherForecastServiceTests
    {
        [Fact]
        public void GetWeatherForecasts_ShouldReturnValidForecasts()
        {
            var service = new WeatherForecastService();
            
            var result = service.GetWeatherForecasts();

            result.Should().NotBeNullOrEmpty();
            result.Should().HaveCount(5);
        }
    }
}