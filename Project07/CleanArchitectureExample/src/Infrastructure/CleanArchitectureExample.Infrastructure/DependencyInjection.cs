using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitectureExample.Application.Commands.CreateTask;
using CleanArchitectureExample.Domain.Interfaces;
using CleanArchitectureExample.Infrastructure.Data;
using CleanArchitectureExample.Infrastructure.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureExample.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, string? connectionString)
        {


            services.AddDbContext<AppDbContext>(options=>{
                options.UseSqlite(connectionString);
            });

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddMediatR(typeof(CreateTaskCommandHandler).Assembly);
            return services;
        }
    }
}