// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hangi ışık yanıyor?\n1. Kırmızı\n2. Sarı\n3. Yeşil");
Console.WriteLine("Lütfen seçiminizi sayı olarak giriniz");
string choose = Console.ReadLine();

if (choose == "1")
{
    Console.WriteLine("DUR!");
}
else if (choose == "2")
{
    Console.WriteLine("DİKKAT!!!");
}
else if (choose == "3")
{
    Console.WriteLine("GEÇ");
}
else
{
    Console.WriteLine("Hatalı seçim....");
}

switch (choose)
{
    case "1":
        Console.WriteLine("DUR!");
        break;
    case "2":
        Console.WriteLine("DİKKAT!!!");
        break;
    case "3":
        Console.WriteLine("GEÇ");
        break;

    default:
        Console.WriteLine("Hatalı seçim....");
        break;
}

switch (DateTime.Now.DayOfWeek)
{
    case DayOfWeek.Monday:
    case DayOfWeek.Tuesday:
    case DayOfWeek.Wednesday:
    case DayOfWeek.Thursday:
    case DayOfWeek.Friday:
        Console.WriteLine("Hafta içi....");
        break;
    case DayOfWeek.Sunday:
    case DayOfWeek.Saturday:
        Console.WriteLine("Hafta sonu");
        break;
    default:
        break;
}