using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compute_the_diff_between_the_largest_and_smallest_values
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Difference(new[] { 1, 5, 7, 9, 10, 12 }));
            Console.WriteLine(Difference(new[] { 1, 5 }));
        }

        //compute the difference between the largest and smallest values in a gvien array of integers and length one or more.
        static int Difference(int[] nums)
        {
            if (nums.Length > 1)
            {
                int largest = nums.Max();
                int smallest = nums.Min();
                int diff = largest - smallest;
                return diff;
            }
            return nums[0];
            
        }
    }
}
