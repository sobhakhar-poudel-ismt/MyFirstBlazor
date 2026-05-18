using MyFirstBlazor.Components;
using MyFirstBlazor.Data;
using MyFirstBlazor.Services;
using Microsoft.EntityFrameworkCore;

namespace MyFirstBlazor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();
        /*    string? connString = builder.Configuration.GetConnectionString("DefaultConnection");
      
            builder.Services.AddDbContext<AppDBContext>(options =>
                options.UseMySql(connString,ServerVersion.AutoDetect(connString)
            ));*/

            //Initlaize Dependency Injection
            builder.Services.AddSingleton<StudentService>();// Only one object
            builder.Services.AddScoped<StudentService>(); //API DI -> one object -> Again API Request -> same object
            builder.Services.AddTransient<StudentService>(); //Every API Request/Load Component -> new object


            var app = builder.Build();
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}


dotnet add package Pomelo.EntityFrameworkCore.MySql --version 8.0.3
dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.3
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.3 
dotnet add package Microsoft.EntityFrameworkCore --version 8.0.3 