using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.WeatherForecasts.Queries;
using FluentValidation;

namespace CleanArchitecture.Application.WeatherForecasts
{
    public class WeatherForecastValidator:AbstractValidator<WeatherForecastDto>
    {
        public WeatherForecastValidator()
        {
            RuleFor(x=>x.TemperatureC).InclusiveBetween(-50,50).WithMessage("Temperature must be between -50 and 50 degrees Celsius.");
            RuleFor(x=>x.Summary).NotEmpty().WithMessage("Summary is required.");
        }
    }
}