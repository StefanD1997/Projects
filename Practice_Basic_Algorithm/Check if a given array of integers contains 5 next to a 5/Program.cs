using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_a_given_array_of_integers_contains_5_next_to_a_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckArr(new[] { 1, 5, 6, 9, 10, 17 }));
            Console.WriteLine(CheckArr(new[] { 1, 5, 5, 9, 10, 17 }));
            Console.WriteLine(CheckArr(new[] { 1, 5, 5, 9, 10, 17, 5, 5 }));
        }

        //check if a given array of integers contains 5 next to a 5
        static bool CheckArr(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 5 && nums[i + 1] == 5)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
