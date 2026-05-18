using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyFirstBlazor.Models.Domain
{
    [Table("products")] // Maps to MySQL table `product`
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // MySQL auto-increment
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Column("price")]
        public double Price { get; set; }

        [Required]
        [Column("category")]
        public string Category { get; set; } = string.Empty;

        [Required]
        [Column("is_active")]
        public bool IsActive { get; set; } = true;

        [Required]
        [Column("stock")]
        public int Stock { get; set; } = 0;
    }

}
