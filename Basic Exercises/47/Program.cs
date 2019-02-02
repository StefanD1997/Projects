using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine("Sum : {0}", ArraySum(nums));
        }

        // compute the sum of all the elements of an array of integers.
        static int ArraySum(int[] nums)
        {
            return nums.Sum();
        }
    }
}
