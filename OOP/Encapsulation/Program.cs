// See https://aka.ms/new-console-template for more information
using Encapsulation;

Console.WriteLine("Hello, World!");

Console.WriteLine("Ürünün fiyatını giriniz:");

decimal price = Convert.ToDecimal(Console.ReadLine());
//if (price < 0)
//{
//    Console.WriteLine("Fiyat negatif olamaz!");
//    return;
//}

Product product = new Product();
product.SetPrice(price);
product.Name = "Deneme";
product.Description = "Açıklama";

Product product2 = new Product { Test = 4, Name="Test name", Description="Test Desc" };
