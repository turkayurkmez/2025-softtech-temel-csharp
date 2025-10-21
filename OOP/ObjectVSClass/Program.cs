// See https://aka.ms/new-console-template for more information
using ObjectVSClass;

Console.WriteLine("Hello, World!");

Product product1 = new Product();
product1.Name = "Gözlük";
Product product2 = new Product();
product2.Name = "Kalem";

Product product3 = product1;


Console.WriteLine(product3.Name);
product3.Name = "Defter";
Console.WriteLine(product1.Name);

Console.WriteLine($"product1 hashCode: ({product1.GetHashCode()}\nproduct3 hashcode: ({product3.GetHashCode()})");
Console.WriteLine($"product2 hascode: ({product2.GetHashCode()})");
if (product1 == product3)
{
    Console.WriteLine("Aynı referans... Tek instance");
}

if (product1 != product2)
{
    Console.WriteLine("iki farklı instance!");
}
//pattern matching:
if (product1 is Product p)
{
    string name = p.Name;
    Console.WriteLine(name);
}