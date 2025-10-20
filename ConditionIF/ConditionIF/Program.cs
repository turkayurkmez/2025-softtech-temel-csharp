// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int x = 5;
if (x % 2 == 0)
{
    Console.WriteLine("Çifttir");
}
else
{
    Console.WriteLine("Tektir");
}

int score = 75;

//&& -> And also
//|| -> Or Else

if (score >= 85 && score <=100)
{
    Console.WriteLine("AA");
}
else if (score >= 75 && score <=84)
{
    Console.WriteLine("AB");
}
else
{
    Console.WriteLine("Yukarıdakilerden hiçbiri");
}

//VE -> HEM .... HEM DE...
//VEYA -> Ya .... Ya da....
string output = string.Empty;
int y = 5;
if (y % 2 == 0)
{
    output = "Çifttir"; 
}
else
{
    output = "Tektir";
}

Console.WriteLine(output);
//ternary operator:
string sameOutput = y % 2 == 0 ? "Çift" : "Tek";

Console.WriteLine(sameOutput);

