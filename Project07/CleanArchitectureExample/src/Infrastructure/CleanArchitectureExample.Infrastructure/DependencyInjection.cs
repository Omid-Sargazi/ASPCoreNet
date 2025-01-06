using CleanArchitectureExample.Application.Commands.CreateTask;
using CleanArchitectureExample.Domain.Interfaces;
using CleanArchitectureExample.Infrastructure.Data;
using CleanArchitectureExample.Infrastructure.Persistence;
using CleanArchitectureExample.Infrastructure.Repositories;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;



namespace CleanArchitectureExample.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, string? connectionString)
        {

            services.AddIdentity<IdentityUser, IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();



            services.AddDbContext<AppDbContext>(options=>{
                options.UseSqlite(connectionString);
            });

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddMediatR(typeof(CreateTaskCommandHandler).Assembly);
            return services;
        }
    }
}