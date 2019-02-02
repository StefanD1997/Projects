using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_whether_a_given_array_of_integers_contains_5_s_and_7_s
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckArr(new[] { 1, 5, 6, 9, 10, 17 }));
            Console.WriteLine(CheckArr(new[] { 1, 4, 7, 9, 10, 17 }));
            Console.WriteLine(CheckArr(new[] { 1, 1, 2, 9, 10, 17 }));
        }

        //check whether a given array of integers contains 5's and 7's
        static bool CheckArr(int[] nums)
        {
            return nums.Contains(5) || nums.Contains(7);
        }
    }
}
