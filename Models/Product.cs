using System.ComponentModel.DataAnnotations;

namespace TechZone.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; }    

        [Required]
        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        

    }
}
