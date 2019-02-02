using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_whether_the_sequence_of_numbers_1__2__3_appear_in_arr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 4, 1, 2, 3, 8 };
            int[] arr2 = { 6, 4, 1, 2, 8, 8 };
            Console.WriteLine(CheckIfSequenceNumbersAppearInArray(arr));
            Console.WriteLine(CheckIfSequenceNumbersAppearInArray(arr2));
            Console.WriteLine(test(arr));
            Console.WriteLine(test(arr2));
        }

        //Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere.

        static bool CheckIfSequenceNumbersAppearInArray(int[] arr)
        {
            int[] arr1 = { 1, 2, 3 };
            var arr1Count = arr1.Count();

            for (int i = 0; i < arr.Count() - arr1Count; i++)
            {
                if (arr.Skip(i).Take(arr1Count).SequenceEqual(arr1))
                    return true;
            }
            return false;
        }

        //Another Example
        public static bool test(int[] nums)
        {
            for (var i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 1 && nums[i + 1] == 2 && nums[i + 2] == 3)
                    return true;
            }
            return false;
        }
    }
}
