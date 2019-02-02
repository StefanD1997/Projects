using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_an_array_of_integers_contains_a_3_next_to_a_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckArr(new[] { 5, 5, 5, 5, 5 }));
            Console.WriteLine(CheckArr(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(CheckArr(new[] { 3, 3, 5, 5, 5, 5 }));
            Console.WriteLine(CheckArr(new[] { 1, 5, 5, 7, 8, 10 }));
        }

        //check if an array of integers contains a 3 next to a 3 or a 5 next to a 5 or both
        static bool CheckArr(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 3 && nums[++i] == 3 || nums[i] == 5 && nums[++i] == 5 || nums[i] == 3 && nums[++i] == 5)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
