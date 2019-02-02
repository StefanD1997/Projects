using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_a_arr_of_ints_and_return_true_if_there_is_a_3_with_a_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckArr(new[] { 3, 5, 1, 3, 7 }));
            Console.WriteLine(CheckArr(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(CheckArr(new[] { 3, 3, 5, 5, 5, 5 }));
            Console.WriteLine(CheckArr(new[] { 2, 5, 5, 7, 8, 10 }));
        }

        //check a given array of integers and return true if there is a 3 with a 5 somewhere later in the given array.
        static bool CheckArr(int[] nums)
        {
            if (nums.Length >= 2)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 3 && nums[i + 1] == 5)
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
        }
    }
}
