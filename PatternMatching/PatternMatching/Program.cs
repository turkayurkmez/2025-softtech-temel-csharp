// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




var person = new Person(8, "Osman", 45, "Eskişehir");
var person1 = new Person(1, "Ayşe", 45, "Amasya");
var person2 = new Person(2, "Zeynep", 17, "Sivas");

List<Person> persons = new List<Person>() { person, person1, person2 };


foreach (var item in persons)
{
    //if (item != null && person.Age > 18 && person.City == "Eskişehir")
    //{
    //    Console.WriteLine("Üç önerme && ile birleşti");
    //}

    //pattern mtching:
    if (item is { Age: > 18  } p)
    {
        Console.WriteLine("Tek bir pattern matching kullanıldı!");
        Console.WriteLine($"{p.Name}");
    }

}




//record tanımı:
public record Person(int Id, string Name, int Age, string City);

