namespace usingTuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int modulo = 0;
            int result = divide(10,3,out modulo);

            var objResult = divide(10, 3);

            var tupleResult = divideTuple(10, 3);
            Console.WriteLine($"Bölüm: {tupleResult.Item2}, Kalan:{tupleResult.Item1}");

            (int bolum, int kalan) = div(10, 3);

            (string name, int age) = ("Türkay", 45);
            

            Console.WriteLine($"decorate tuple bölüm: {bolum} ve kalan {kalan} ");
        }

        static int divide(int number, int divider, out int modulo)
        {
            modulo = number % divider;
            return number / divider;
        }

        static DivisionResult divide(int num1, int num2)
        {
            return new DivisionResult
            {
                Modulo = num1 % num2,
                Result = num1 / num2
            };
        }

        static Tuple<int, int> divideTuple(int num1, int num2) { 

            return Tuple.Create(
                                num1 % num2, 
                                num1 / num2
                                );


        
        }

        static (int division, int modulo) div(int num1, int num2) {
            return (num1 / num2, num1 % num2);
        }

    }
}
