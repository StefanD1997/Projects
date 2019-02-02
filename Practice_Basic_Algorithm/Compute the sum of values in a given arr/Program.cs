using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compute_the_sum_of_values_in_a_given_arr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(new[] { 1, 5, 7, 9, 10, 17 }));
        }

        //compute the sum of values in a given array of integers except the number 17. Return 0 if the given array has no integer
        static int Sum(int[] nums)
        {
            int Sum = 0;
            foreach (int item in nums)
            {
                if (item == 17)
                {
                    Sum += 0;
                }
                else
                {
                    Sum += item;
                }
            }
            return Sum;
        }
    }
}
