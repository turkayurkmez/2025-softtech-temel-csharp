//
Console.WriteLine("Hello, World!");
int currentYear =  DateTime.Now.Year;
Console.WriteLine("Lütfen doğum yılınızı giriniz:");
string? answer = Console.ReadLine();
int birthDate = Convert.ToInt32(answer);
int age = currentYear - birthDate;
Console.WriteLine("yaşınız " + age);

/*
 * sayısal
 *   tam sayılar
 *   ondalıklı sayılar
 * sözel
 * mantıksal
 */

byte eightBit = 255;
sbyte signedEightBit = 127;

Console.WriteLine("Bir sayı giriniz:");
byte x = byte.Parse(Console.ReadLine());
Console.WriteLine("Bir sayı daha giriniz:");

byte y = Convert.ToByte(Console.ReadLine());

try
{
    checked
    {
        byte total = (byte)(x + y);
        Console.WriteLine($"{x} ve {y} byte değerlerinin toplamı {total}");
    }
}
catch(OverflowException ) 
{
    Console.WriteLine("Toplam değer, byte tipine atanamıyor. Lütfen toplam en fazla 255 olacak biçimde sayılar giriniz");
}


short sixteenBit = 32767;
ushort unSignedSixteenBit = 65535;

int thirhtyTwo = 0;
//uint
long veryBig = 0;
//ulong 

double pi = 3.14d;
float fPi = 3.14f;
decimal decPi = 3.14m;

char symbol = '!';
string multipleChar = "Selam!";

bool isColored = false;

