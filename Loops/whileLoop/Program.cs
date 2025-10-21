// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Random randomNumberGenerator = new Random ();
string userAnswer = string.Empty;
do
{
    var generatedNumber = randomNumberGenerator.Next(1, 100);
    var isNumberFinded = false;
    while (!isNumberFinded)
    {
        Console.WriteLine("Sayıyı tahmin edin:");
        int suggestedNumber = Convert.ToInt32(Console.ReadLine());
        if (generatedNumber > suggestedNumber)
        {
            Console.WriteLine("Yukarı");
        }
        else if (generatedNumber < suggestedNumber)
        {
            Console.WriteLine("Aşağı");
        }
        else
        {
            Console.WriteLine("Bildiniz");
            isNumberFinded = true;
        }
    }
    Console.WriteLine("Tekrar oynamak ister misiniz? (E/H)"); 
    userAnswer = Console.ReadLine();
} while (userAnswer == "E");

