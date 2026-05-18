using System.ComponentModel.DataAnnotations;

namespace MyFirstBlazor.Components.ViewModel
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
        }

        public ProductViewModel(MyFirstBlazor.Models.Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Price = product.Price;
            Category = product.Category;
            IsActive = product.IsActive;
            Stock = product.Stock;
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public double Price { get; set; }

        [Required]
        public string Category { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;

        [Required]
        public int Stock { get; set; }

        public MyFirstBlazor.Models.Product ToProduct()
        {
            return new MyFirstBlazor.Models.Product
            {
                Id = Id,
                Name = Name,
                Price = Price,
                Category = Category,
                IsActive = IsActive,
                Stock = Stock
            };
        }
    }
}
