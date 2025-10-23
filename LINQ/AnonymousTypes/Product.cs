using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }

    public class ProductService
    {
        public List<Product> GetProducts()
        {
            var products = new List<Product>();
            var categories = new[] { "Electronics", "Clothing", "Books", "Home & Garden", "Sports", "Toys", "Food", "Beauty" };
            var productNames = new[] { "Laptop", "Smartphone", "Tablet", "Headphones", "Camera", "Watch", "Keyboard", "Mouse", "Monitor", "Speaker" };
            var random = new Random();

            for (int i = 1; i <= 50; i++)
            {
                products.Add(new Product
                {
                    Id = i,
                    Name = $"{productNames[random.Next(productNames.Length)]} {i}",
                    Category = categories[random.Next(categories.Length)],
                    Price = Math.Round((decimal)(random.NextDouble() * 1000 + 10), 2),
                    Stock = random.Next(0, 100)
                });
            }

            return products;
        }
    }
}
