using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_a_specified_number_is_present_in_a_array_of_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 6, 7, 3, 4 };
            Console.WriteLine(CheckIfIntegerIsInArray(arr, 4));
            Console.WriteLine(test(arr, 5));
        }

        static bool CheckIfIntegerIsInArray(int[] arr, int n)
        {
            if (arr.Contains(n))
            {
                return true;
            }
            return false;
        }

        //Another Example
        public static bool test(int[] numbers, int n)
        {
            return numbers.Length < 4 ? numbers.Contains(n) : numbers/*.Take(4)*/.Contains(n);
        }
    }
}
