using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_the_sum_of_5_in_the_arr_15_in_a_given_arr_of_ints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckArr(new[] { 1, 5, 6, 9, 10, 17 }));
            Console.WriteLine(CheckArr(new[] { 1, 5, 5, 5, 10, 17 }));
            Console.WriteLine(CheckArr(new[] { 1, 1, 5, 5, 5, 5 }));
        }

        //check if the sum of all 5' in the array exactly 15 in a given array of integers
        static bool CheckArr(int[] nums)
        {
            int sum = 15;
            int othersum = 0;
            foreach (int item in nums)
            {
                if (item == 5)
                {
                    othersum += item;
                }
                othersum += 0;
            }

            return sum == othersum;
        }
    }
}
