// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//input, output, reference, params keyword'leri....
int getSquare(int x)
{
    return x * x;
}


int divide(int number, int divider, out int modulo)
{
    modulo = number % divider;
    return number / divider;
}

void refSample(ref int x)
{
    x += 5;
    Console.WriteLine($"refSample metodu içinde x: {x}");
}

int getTotal(bool isPositive, params int[] values) {
    return values.Sum();
}
//kullanım alanı:
//input
int square = getSquare(5);


//out
int moduloKova = 0;
int divideOutput = divide(14, 3, out moduloKova);
Console.WriteLine($"Sonuç: {divideOutput}, kalan:{moduloKova}");

//ref:
int x = 17;
refSample(ref x);
Console.WriteLine($"main metodu içinde x: {x}");

//params:
Console.WriteLine($"params test: {getTotal(true, 13,45,-1,13,56,45)}");


