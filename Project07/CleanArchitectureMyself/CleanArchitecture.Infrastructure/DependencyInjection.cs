using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Infrastructure.Persistence;
using CleanArchitecture.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var useSqlite = configuration.GetValue<bool>("UseSqlite");
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            if(useSqlite)
            {
                services.AddDbContext<ApplicationDbContext>(options=>
                options.UseSqlite(connectionString)
                );
            }
            else
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            }




            services.AddSingleton<IWeatherForecastService,WeatherForecastService>();

            services.AddScoped<IApplicationDbContext>(provider=> provider.GetRequiredService<ApplicationDbContext>());
            services.AddScoped<ITodoRepository,TodoRepository>();
            return services;
        }
    }
}