// See https://aka.ms/new-console-template for more information
using AnonymousTypes;

Console.WriteLine("Hello, World!");

var anonyomus = new { Name = "Softtech", Location = "İstanbul" };

var x = "5";
x = "selam";

var productService = new ProductService();

//LINQ Sorgusu: 
var products = from product in productService.GetProducts()
               where product.Price <= 500
               orderby product.Price
               select new { Name = product.Name, Price = product.Price };

//LINQ Extension:
var productsExtension = productService.GetProducts()
                             .Where(p => p.Price <= 500)
                             .OrderBy(p => p.Price)
                             .Select(p => new { Name = p.Name, Price = p.Price });


Console.WriteLine($"Toplam: {products.Count()} ürün");
foreach (var item in products)
{
    Console.WriteLine($"{item.Name}\t{item.Price}");
}
//Select * from Products where price <= 500