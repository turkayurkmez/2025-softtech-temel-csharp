// See https://aka.ms/new-console-template for more information
try
{
	Console.WriteLine("Bölünecek sayıyı girin");
	int number = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Bölen sayıyı girin:");
	int divider = Convert.ToInt32(Console.ReadLine());

	int result = number / divider;

	Console.WriteLine($"Bölüm: {result}");
}
catch (FormatException)
{

    Console.WriteLine("Lütfen yalnızca sayı giriniz");
}
catch (DivideByZeroException)
{
	Console.WriteLine("Tam sayılar 0'a bölünemez");
	return;

}
catch (Exception error)
{
	Console.WriteLine(error.Message);

}
finally//ne olursa olsun (hata alsan da almasan da) çalış:
{
    Console.WriteLine("Çalışır mı?");
}




//1. FormatException
//2. DivideByZeroException

