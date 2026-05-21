using Microsoft.EntityFrameworkCore;
using MyFirstBlazor.Models.Domain;


//DashboardDbContext
//AuthDbContext -> properrietes-> DBSet<DomainModel>
namespace MyFirstBlazor.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        public DbSet<Product> Products { get; set; }

    }
}
