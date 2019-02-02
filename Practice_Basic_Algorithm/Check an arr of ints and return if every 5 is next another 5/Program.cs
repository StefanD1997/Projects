using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_an_arr_of_ints_and_return_if_every_5_is_next_another_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckArr(new[] { 3, 5, 5, 3, 7 }));
            Console.WriteLine(CheckArr(new[] { 3, 5, 5, 4, 1, 5, 7 }));
            Console.WriteLine(CheckArr(new[] { 3, 5, 5, 5, 5, 5 }));
            Console.WriteLine(CheckArr(new[] { 2, 4, 5, 5, 6, 7, 5 }));
        }

        //check a given array of integers and return true if every 5 that appears in the given array is next to another 5.
        static bool CheckArr(int[] nums)
        {
            bool flag = true;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 5)
                {
                    if ((i > 0 && nums[i - 1] == 5) || (i < nums.Length - 1 && nums[i + 1] == 5)) flag = true;
                    else if (i == nums.Length - 1) flag = false;
                    else return false;
                }
            }
            return flag;
        }
    }
}
