using CleanArchitectureExample.Application.Commands.CreateTask;
using CleanArchitectureExample.Infrastructure;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddMediatR(typeof(CreateTaskCommandHandler).Assembly);
// builder.Services.AddInfrastructureServices();

builder.Services.AddInfrastructureServices(builder.Configuration.GetConnectionString("DefaultConnection"));




var app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}


app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();


app.Run();