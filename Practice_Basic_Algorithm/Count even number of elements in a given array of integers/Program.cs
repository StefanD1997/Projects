using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_even_number_of_elements_in_a_given_array_of_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Count(new[] { 1, 5, 7, 9, 10, 12 }));
        }

        //count even number of elements in a given array of integers.
        static int Count(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
