// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




var person = new Person(8, "Osman", 45, "Eskişehir","Mühendis");
var person1 = new Person(1, "Ayşe", 45, "Amasya","Öğretmen");
var person2 = new Person(2, "Zeynep", 17, "Sivas","Esnaf");

List<Person> persons = new List<Person>() { person, person1, person2 };


foreach (var item in persons)
{
    //if (item != null && person.Age > 18 && person.City == "Eskişehir")
    //{
    //    Console.WriteLine("Üç önerme && ile birleşti");
    //}

    //if (item is Person)
    //{
    //    var pr = (Person)item;
    //    Console.WriteLine(pr.Name);
    //}

    //pattern mtching:
    if (item is { Age: >18, City:"Eskişehir" } p)
    {
        Console.WriteLine("Tek bir pattern matching kullanıldı!");
        Console.WriteLine($"{p.Name}");
    }

}


List<CityDetails> cityDetails = new List<CityDetails>()
{
    new(1,"Eskişehir","İç Anadolu",800000),
    new(2,"İstanbul","Marmara",20000000),
    new(3,"Ankara","İç Anadolu",4900000)
};

//Property Pattern:
string analyzeCity(CityDetails cityDetails)
{
    return cityDetails switch
    {
        { Population: <= 500000 } => "Küçük şehir",
      //  { Population: < 1000000} => "Normal büyükükte",
        { Population: > 10000000} => "Kalabalık",
        { Region: "İç Anadolu", Population: <= 1000000} => "Anadolu'nun kalbinde normal bir şehir",
        { Population: >= 1000000 and <=5000000 } => $" Potansiyel risk"
    };
}

foreach (var item in cityDetails)
{
    Console.WriteLine($"{item.Name}:{analyzeCity(item)}");
}

//Tuple Pattern 
string getMovementDirection(int deltaX, int deltaY)
{
    return (deltaX, deltaY) switch
    {
        (0,0) =>"Durgun",
        (>0,0) =>"Doğu",
        (<0,0) =>"Batı",
        (0,>0) =>"Kuzey",
        (0,<0) =>"Güney",
        (>0,>0)=>"Kuzeydoğu",
        (<0,>0) => "Kuzeybatı",
        (>0,<0) => "Güneydoğu",
        (<0,<0) =>"GüneyBatı"      
        

    };
}

//Relational Pattern:
string getTemperatureStatus(double celcius)
{
    return celcius switch
    {
        < 0 => "Donuyor",
        >= 0 and < 10 => "Çok soğuk",
        >= 10 and < 20 => "Soğuk",
        >= 20 and < 30 => "Ilık",
        double.NaN => "Hatalı ölüm",
        _ => "Tanımsız değer"
    };
}

Console.WriteLine("x:5 y:7 ise " + getMovementDirection(5,7));
Console.WriteLine("x:0 y:-7 ise " + getMovementDirection(0, -7));
Console.WriteLine("x:-1 y:0 ise " +  getMovementDirection(-1, 0));

Console.WriteLine($"Hava sıcaklığı: 15 derece -> {getTemperatureStatus(15)}");
Console.WriteLine($"Hava sıcaklığı: 25 derece -> {getTemperatureStatus(25)}");
Console.WriteLine($"Hava sıcaklığı: -5 derece -> {getTemperatureStatus(-5)}");





//record tanımı:
public record Person(int Id, string Name, int Age, string City, string Job);

public record CityDetails(int Id, string Name,string Region, int Population);
