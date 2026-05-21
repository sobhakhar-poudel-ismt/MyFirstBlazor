using MyFirstBlazor.Models.Domain;
using MyFirstBlazor.Models.ViewModel;
using MyFirstBlazor.Data;
using Microsoft.EntityFrameworkCore;

namespace MyFirstBlazor.Services
{
    public class ProductRegistrationService
    {
        private readonly AppDbContext appDbContext;

        public ProductRegistrationService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await appDbContext.Products.ToListAsync();
        }

        public async Task AddProductAsync(ProductViewModel productViewModel)
        {
            await appDbContext.Products.AddAsync(productViewModel.ToProduct());
            await appDbContext.SaveChangesAsync();
        }
    }
}
