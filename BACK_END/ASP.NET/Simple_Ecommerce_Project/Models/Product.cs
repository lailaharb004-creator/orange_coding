using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simple_Ecommerce_Project.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductTitle { get; set; }
        public string ProductDescription { get; set; }
        [Required]
        public double ProductPrice { get; set; }
        public int ProductCategoryId { get; set; }

        [ForeignKey("ProductCategoryId")]
        public Category Category { get; set; } // Navigation Property
        public string ImageUrl { get; set; }
    }
}
