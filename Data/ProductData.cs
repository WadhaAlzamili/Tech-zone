using System.Collections.Generic;
using TechZone.Models;

namespace TechZone.Data
{
    public static class ProductData
    {
        public static List<Product> Products = new List<Product>
        {
            new Product
            {
                ProductId = 1,
                Name = "Phone",
                Category = "Smart Phone",
                Price = 3400,
                ImageUrl = "/images/products/phone.png",
                Description = "Smartphone with a sleek design"
            },
            new Product
            {
                ProductId = 2,
                Name = "Laptop",
                Category = "Laptop",
                Price = 5400,
                ImageUrl = "/images/products/laptop.png",
                Description = "Powerful laptop for work"
            },
            new Product
            {
                ProductId = 3,
                Name = "Wireless Headphones",
                Category = "Accessory",
                Price = 320,
                ImageUrl = "/images/products/headphones.png",
                Description = "Noise cancelling headphones"
            },
            new Product
            {
                ProductId = 4,
                Name = "Smart Watch",
                Category = "Accessory",
                Price = 900,
                ImageUrl = "/images/products/smartwatch.png",
                Description = "Health tracking smart watch"
            },
            new Product
            {
                ProductId = 5,
                Name = "Tablet",
                Category = "Tablet",
                Price = 2200,
                ImageUrl = "/images/products/tablet.png",
                Description = "Portable tablet"
            },
            new Product
            {
                ProductId = 6,
                Name = "Mouse",
                Category = "Accessory",
                Price = 120,
                ImageUrl = "/images/products/mouse.png",
                Description = "Wireless mouse"
            }
        };
    }
}
