using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingDelegates
{
    public static class Filter
    {
       // public delegate bool Criteria(int number);
       public static int[] FilterNumbers(int[] numbers, Func<int,bool> criteria)
        {
            List<int> filteredNumbers = new List<int>();
            foreach (var number in numbers)
            {
                if (criteria(number))
                {
                    filteredNumbers.Add(number);
                }
            }

            return filteredNumbers.ToArray();
        }

        public static void OperateWithNumbers(int[] numbers,Action<int[]> action) {

            action(numbers);
        }


    }
}
