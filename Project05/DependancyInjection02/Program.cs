using DependancyInjection02.MainClasses;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

builder.Services.AddTransient<AppInfoService>();







// Add services to the container.
//builder.Services.AddRazorPages();

var app = builder.Build();

using var scope = app.Services.CreateScope();
var appInfoService = scope.ServiceProvider.GetRequiredService<AppInfoService>();
appInfoService.DisplayAppInfo();

// // Configure the HTTP request pipeline.
// if (!app.Environment.IsDevelopment())
// {
//     app.UseExceptionHandler("/Error");
//     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//     app.UseHsts();
// }

// app.UseHttpsRedirection();
// app.UseStaticFiles();

// app.UseRouting();

// app.UseAuthorization();

// app.MapRazorPages();

app.Run();
