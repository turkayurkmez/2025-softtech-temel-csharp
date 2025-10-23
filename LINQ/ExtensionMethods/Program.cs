// See https://aka.ms/new-console-template for more information
using ExtensionMethods;

Console.WriteLine("Hello, World!");

int number = 5;
Console.WriteLine(number.GetSquare());
string name = "aHmeT meHmet deLiOğlan";
Console.WriteLine(name.ToTitleCase());

Random random = new Random();
Console.WriteLine(random.NextChar(CharType.Symbol));
for (int i = 1; i < 11; i++)
{
    Console.WriteLine(random.NextPassword(i));
}
