using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compute_the_sum_of_the_elements_of_an_given_array_of_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(new[] { 10, 20, 30, 40, 50 }));
            Console.WriteLine(Sum(new[] { 10, 20, -30, -40, 50 }));
        }

        //compute the sum of the elements of an given array of integers
        static int Sum(int[] nums)
        {
            //nums.Sum();
            int result = 0;
            foreach (int item in nums)
            {
                result += item;
            }
            return result;
        }
    }
}
