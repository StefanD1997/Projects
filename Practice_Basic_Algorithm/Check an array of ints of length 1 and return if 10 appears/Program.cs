using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_an_array_of_ints_of_length_1_and_return_if_10_appears
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckArr(new[] { 10, 20, 40, 50 }));
            Console.WriteLine(CheckArr(new[] { 5, 20, 40, 10 }));
            Console.WriteLine(CheckArr(new[] { 10, 20, 40, 10 }));
            Console.WriteLine(CheckArr(new[] { 12, 24, 35, 55 }));
        }

        // check a given array of integers of length 1 or more and return true if 10 appears as either first or
        //last element in the given array
        static bool CheckArr(int[] nums)
        {
            return nums[0] == 10 || nums[nums.Length - 1] == 10;
        }
    }
}
