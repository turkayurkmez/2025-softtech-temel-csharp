// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string word = "adana";
if (word.EndsWith("tech"))
{
    Console.WriteLine("tech ile biter");
}

var runes = word.EnumerateRunes();
foreach (var item in runes)
{
    Console.WriteLine($"Plane: { item.Plane }\nValue: {item.Value} {(char)item.Value}\nUTF8Length   {item.Utf8SequenceLength}\nIs Ascii: {item.IsAscii}");
}

int startIndex = 0;
var findingIndex = word.IndexOf('a',startIndex);
Console.WriteLine($"p harfinin indexi: {findingIndex}");

Console.WriteLine($"{word.IndexOf('a',0)}");
Console.WriteLine($"{word.IndexOf('a', 1)}");
Console.WriteLine($"{word.IndexOf('a', 3)}");
Console.WriteLine($"{word.IndexOf('a', 5)}");

while (findingIndex != -1)
{
   
    startIndex = findingIndex +1;
    Console.Write(findingIndex);
    findingIndex = word.IndexOf('a', startIndex);
}
Console.WriteLine();