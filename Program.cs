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
            string? connString = builder.Configuration.GetConnectionString("DefaultConnection");
      
            builder.Services.AddDbContext<AppDBContext>(options =>
                options.UseMySql(connString,ServerVersion.AutoDetect(connString)
            ));

            //Initlaize Dependency Injection
            builder.Services.AddSingleton<StudentService>();
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
