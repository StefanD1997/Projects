using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_a_given_arr_of_ints__does_not_contain_15_or_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckArr(new[] { 12, 20 }));
            Console.WriteLine(CheckArr(new[] { 14, 15 }));
            Console.WriteLine(CheckArr(new[] { 11, 21 }));
        }

        //check if a given array of integers and length 2, does not contain 15 or 20
        static bool CheckArr(int[] nums)
        {
            if (nums.Length >= 2)
            {
                if (nums.Contains(15) || nums.Contains(20))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
