// See https://aka.ms/new-console-template for more information
using usingRecordTypes;

Console.WriteLine("Hello, World!");

Product p1 = new Product()
{
    Name = "Ürün A",
    Price = new Money { Amount = 100, Currency = "TL" }
};
Product p2 = new Product()
{
    Name = "Ürün B",
    Price = new Money { Amount = 100, Currency = "TL" }
};

if (p1.Price == p2.Price)
{
    Console.WriteLine("iki ürünün fiyatı eşittir");
}
else
{
    Console.WriteLine("Fiyatlar eşit değil");
}


ProductWithRecord pr1 = new ProductWithRecord()
{
    Name = "Ürün C",
    Price = new MoneyRecord { Amount = 100, Currency = "Dolar" }
};

ProductWithRecord pr2 = new ProductWithRecord()
{
    Name = "Ürün D",
    Price = new MoneyRecord { Amount = 100, Currency = "TL" }
};

Console.WriteLine("-------- Record karşılaştırması -------------");
if (pr1.Price == pr2.Price)
{
    Console.WriteLine("iki ürünün fiyatı eşittir");
}
else
{
    Console.WriteLine("Fiyatlar eşit değil");
}

Employee employee = new Employee { Id = 1, Name = "Ali", Descriprtion = "IT" };

EmployeeRecord employeeRecord = new EmployeeRecord(1, "Mehmet", "İK");
EmployeeRecord employeeRecord2 = new EmployeeRecord(2, "Mehmet", "İK");
/*employeeRecord.Name = "Türkay"*/

if (employeeRecord == employeeRecord2)
{
    Console.WriteLine("İki employeeRecord nesnesi de aynı değerlere sahip");
}

