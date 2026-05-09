using System.ComponentModel.DataAnnotations;

namespace Simple_Ecommerce_Project.Models
{
    public class Category
    {

        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public string? ImageUrl { get; set; }
    }
}
