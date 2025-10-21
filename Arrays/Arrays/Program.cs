// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
//1. Kapasiteyi biliyorum, değerleri bilmiyorum.
int[] ages = new int[10];
ages[0] = 35;
ages[9] = 24;
//2. Değerleri biliyorum:
string[] monthNames = { "Ocak","Şubat","Mart","Nisan","Mayıs" };
int[] digits = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
Console.WriteLine(monthNames[0]);
Console.WriteLine(monthNames[monthNames.Length-1]);

Console.WriteLine($"Son ay: {monthNames[^1]}");
Console.WriteLine($"Son ay: {monthNames[^2]}");


Console.WriteLine(string.Join(",", digits[0..3]));
Console.WriteLine(string.Join(",", digits[3..7]));
Console.WriteLine(string.Join(",", digits[^3..^0]));

/*
 *  54
 *  Elli dört
 */

string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };

Console.WriteLine("İki basamaklı bir sayı girin:");
string number = Console.ReadLine();
if (number.Length <=2 )
{
    int num = Convert.ToInt32(number);
    int valueTen = num / 10;
    int valueOne = num % 10;

    Console.WriteLine(onlar[valueTen] + " " + birler[valueOne]);

}

for (int i =1; i < 100; i++)
{
    int valueTen = i / 10;
    int valueOne = i % 10;

    Console.WriteLine(onlar[valueTen] + " " + birler[valueOne]);
}