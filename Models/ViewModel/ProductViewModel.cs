using MyFirstBlazor.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace MyFirstBlazor.Models.ViewModel {
    public class ProductViewModel
    {
        public ProductViewModel()
        {
        }

        public ProductViewModel(Product product)
        {
            Name = product.Name;
            Price = product.Price;
            Category = product.Category;
            IsActive = product.IsActive;
            Stock = product.Stock;
        }



        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Must be between 2 and 100 characters")]
        public string Name { get; set; } = string.Empty;

        [Required]
        public double Price { get; set; }

        [Required]
        public string Category { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;

        [Required]
        public int Stock { get; set; }

        public Product ToProduct()
        {
            return new Product
            {
                Name = Name,
                Price = Price,
                Category = Category,
                IsActive = IsActive,
                Stock = Stock
            };
        }

        public void UpdateDomain(Product product)
        {
            product.Name = Name;
            product.Price = Price;
            product.Category = Category;
            product.IsActive = IsActive;
            product.Stock = Stock;
        }
    }

}

