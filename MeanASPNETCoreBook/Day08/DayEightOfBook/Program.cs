using System.Text;
using System.Threading.Tasks;
using DayEightOfBook.Data;
using DayEightOfBook.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

public class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("omid");

        var builder = WebApplication.CreateBuilder(args);
        // builder.Services.AddDbContext<AppDbContext>(options=> {
        //     options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
        // });
        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite("Data Source=app.db"));

        builder.Services.AddControllers();

        builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
        .AddEntityFrameworkStores<AppDbContext>()
        .AddDefaultTokenProviders();

        var key = Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:Secret"]);

        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options => {
            options.RequireHttpsMetadata = false;
            options.SaveToken = true;
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime  = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key)
            };
        });



        builder.Services.AddAuthorization(options=> {
            options.AddPolicy("AdminOnly", policy => policy.RequireRole("Admin"));
        });

        builder.Services.AddAuthorization();
        builder.Services.AddControllers();

        
        
        var app = builder.Build();




        app.UseAuthentication();
        app.UseAuthorization();
        app.MapControllers();

        using(var scope = app.Services.CreateScope())
        {
            var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if(!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }

            if(!await roleManager.RoleExistsAsync("User"))
            {
                await roleManager.CreateAsync(new IdentityRole("User"));
            }
            dbContext.Database.EnsureCreated();

            if(!dbContext.Products.Any())
            {
                dbContext.Products.AddRange(new List<Product>
                    {
                         new Product { Name = "Laptop", Price = 1200 },
                    new Product { Name = "Phone", Price = 800 }
                    }
                );
                dbContext.SaveChanges();
            }
        }
        app.Run();
    }
}