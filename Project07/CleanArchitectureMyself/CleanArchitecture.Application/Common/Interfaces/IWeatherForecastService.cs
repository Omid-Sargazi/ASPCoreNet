using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.WeatherForecasts.Queries;

namespace CleanArchitecture.Application.Common.Interfaces
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecastDto> GetWeatherForecasts();
    }
}