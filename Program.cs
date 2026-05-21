using Microsoft.EntityFrameworkCore;
using MyFirstBlazor.Data;
using MyFirstBlazor.Components;
using MyFirstBlazor.Services;


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

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseMySql(connString, ServerVersion.AutoDetect(connString)
            ));

            //Initlaize Dependency Injection
            builder.Services.AddScoped<StudentService>(); //API DI -> one object -> Again API Request -> same object
            builder.Services.AddScoped<ProductRegistrationService>();


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
