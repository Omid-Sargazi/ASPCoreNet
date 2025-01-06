using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitectureExample.Application.Commands.CreateTask;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureExample.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(CreateTaskCommandHandler).Assembly);
            return services;
        }
    }
}