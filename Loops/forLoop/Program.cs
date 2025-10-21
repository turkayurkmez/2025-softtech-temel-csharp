// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var numbers = new int[] { 1, -5, 96, 13, 16, 104 };

bool isNegativeNumberExists = false;
for (int index = 0; index < numbers.Length; index++)
{
	if (numbers[index] < 0)
	{
		isNegativeNumberExists = true;
		break;
	}
}

string status = isNegativeNumberExists ? "var" : "yok";
Console.WriteLine($"Negatif sayı {status}");