// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> numbers = new() { 19, -9, 26, -8, 12 };
bool isNegativeNumberExists(List<int> numbers)
{
    var isExists = false;
    foreach (var number in numbers)
    {
        if (number < 0)
        {
            isExists = true;
            break;
        }
    }

    return isExists;
}

bool isNegativeNumberExistsShort(List<int> numbers) =>  numbers.Any(n => n < 0);



int? findFirstNegativeNumber(List<int> numbers)
{
    int? findingNumber = null;
    foreach (var number in numbers)
    {
        if (number < 0)
        {
            findingNumber = number;
            break;
        }
    }
    return findingNumber;
}

int? findFirstNegativeNumberShort(List<int> numbers)=>
   numbers.FirstOrDefault(n => n < 0);
   
  



List<int> getNegativeNumbers(List<int> numbers)
{
    var negativeNumbers = new List<int>();
    foreach (var number in numbers)
    {

        if (number < 0)
        {
            negativeNumbers.Add(number);
        }

    }

    return negativeNumbers;
}

List<int> getNegativeNumbersShort(List<int> numbers)=>
     numbers.Where(n => n < 0).ToList();

//kullanım:
if (isNegativeNumberExists(numbers))
{
    Console.WriteLine("koleksiyon içinde negatif sayı var!");
}

string? output = findFirstNegativeNumber(numbers) == null ? "negatif sayı yok" : findFirstNegativeNumber(numbers).ToString();
Console.WriteLine(output);

string allNegatives = string.Join(",", getNegativeNumbers(numbers));
Console.WriteLine(allNegatives);