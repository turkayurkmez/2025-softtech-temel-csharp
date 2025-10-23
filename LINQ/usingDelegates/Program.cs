// See https://aka.ms/new-console-template for more information
using usingDelegates;

Console.WriteLine("Hello, World!");
var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


bool isEven(int number)
{
    return number % 2 == 0;
}

bool isOdd(int number)
{
    return number %2 == 1;
}

//void showNumbers(int[] numbers)
//{
//    Console.WriteLine(string.Join(",",numbers));
//}
//v1.0:
 var evenNumbers = Filter.FilterNumbers(numbers,isEven);
//v2.0
var bigThanFive = Filter.FilterNumbers(numbers, delegate (int num) { return num > 5; });
//v3.5:
var smallThanFive = Filter.FilterNumbers(numbers, n => n < 5);
//showNumbers(evenNumbers);
//showNumbers(bigThanFive);
//showNumbers(smallThanFive);

Filter.OperateWithNumbers(evenNumbers, nums => Console.WriteLine( string.Join(",", nums)));
Filter.OperateWithNumbers(smallThanFive, nums => nums.ToList().ForEach(x => Console.WriteLine(x)));

var result = numbers.Where(n => n >= 8)
                    .ToList();
Console.WriteLine("--------------------------");
result.ForEach(x => Console.WriteLine(x));
                      


