using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_one_of_the_first_4_ints_in_an_array_are_equal_to_n
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 8, 6, 9, 3 };
            Console.WriteLine(CheckFirst4IntsInArr(arr, 3));
            Console.WriteLine(CheckFirst4IntsInArr(arr, 5));
            Console.WriteLine(CheckFirst4IntsInArr(arr, 1));
            Console.WriteLine(CheckFirst4IntsInArr(arr, 8));
            Console.WriteLine(CheckFirst4IntsInArr(arr, 6));
            Console.WriteLine(CheckFirst4IntsInArr(arr, 9));
        }


        //Write a C# Sharp program to check if one of the first 4 elements in an array of integers is equal to a given element.
        static bool CheckFirst4IntsInArr(int[] nums, int n)
        {
            if (nums.Length > 0 && nums.Take(4).Contains(n))
            {
                return true;
            }
            return false;
        }

        //Antoher Example
        public static bool test(int[] numbers, int n)
        {
            return numbers.Length < 4 ? numbers.Contains(n) : numbers.Take(4).Contains(n);
        }
    }
}
