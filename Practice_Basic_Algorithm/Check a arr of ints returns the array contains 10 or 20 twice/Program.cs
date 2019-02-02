using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_a_arr_of_ints_returns_the_array_contains_10_or_20_twice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 20, 0, 48, 20 };
            Console.WriteLine(CheckArr(x));
        }

        //check a given array of integers and return true if the array contains 10 or 20 twice.The length of the
        //array will be 0, 1, or 2. 
        static bool CheckArr(int[] nums)
        {
            int[] Arr = nums.Where(n => n == 10).Select(n => n).ToArray();
            int[] Arr2 = nums.Where(n => n == 20).Select(n => n).ToArray();
            return Arr.Count() == 2 || Arr2.Count() == 2;
        }
    }
}
