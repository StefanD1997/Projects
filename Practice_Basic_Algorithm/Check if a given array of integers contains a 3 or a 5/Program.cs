using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_a_given_array_of_integers_contains_a_3_or_a_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckArr(new[] { 5, 5, 5, 5, 5 }));
            Console.WriteLine(CheckArr(new[] { 3, 3, 3, 3 }));
            Console.WriteLine(CheckArr(new[] { 3, 3, 3, 5, 5, 5 }));
            Console.WriteLine(CheckArr(new[] { 1, 6, 8, 10 }));
        }

        //check if a given array of integers contains a 3 or a 5
        static bool CheckArr(int[] nums)
        {
            return nums.Contains(3) || nums.Contains(5);
        }

    }
}
