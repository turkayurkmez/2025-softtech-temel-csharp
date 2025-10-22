// See https://aka.ms/new-console-template for more information
using BuiltinInterfaces;

Console.WriteLine("Hello, World!");

List<Student> students = new ()
{
    new(){ Id=1, Name ="Türkay", Score=90},
    new(){ Id=2, Name ="Berke", Score=75},
    new(){ Id=3, Name ="Tuğba", Score=100}


};

ClassRoom room = new ClassRoom();
room.AddRange(students);
room.SortStudents();
foreach (var item in room)
{
    Console.WriteLine($"{item.Name}\t{item.Score}");
}