using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineMedicalAppointmentSystem.Application.Commands;
using OnlineMedicalAppointmentSystem.Application.DTOs;
using OnlineMedicalAppointmentSystem.Application.Mappings;
using OnlineMedicalAppointmentSystem.Application.Queries;
using OnlineMedicalAppointmentSystem.Infrastructure.Data;
using OnlineMedicalAppointmentSystem.Infrastructure.Repositories;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

        builder.Services.AddDbContext<AppDbContext>(options=>{
            options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"),
            b=>b.MigrationsAssembly("OnlineMedicalAppointmentSystem.Infrastructure")
            );
        });

        builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        builder.Services.AddScoped<ICommandHandler<BookAppointmentCommand>, BookAppointmentCommandHandler>();
        builder.Services.AddScoped<IQueryHandler<GetAppointmentQuery, AppointmentDto>, GetAppointmentQueryHandler>();

        // AutoMapper
        var mapperConfig = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
        builder.Services.AddSingleton(mapperConfig.CreateMapper());

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();

       var app = builder.Build();

    // Configure the HTTP request pipeline
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();

        app.UseHttpsRedirection();


        app.Run();


    }
}