using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _135
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindLargestNum(new[] { 1, 2, 3, 4, 6, 8 }));
            Console.WriteLine(FindLargestNum(new[] { 15, 2, 3, 4, 15, 11 }));
        }

        //find the larger average value between the first and the second half of a given array of integers 
        //and minimum length is atleast 2. Assume that the second half begins at index (array length)/2
        static double FindLargestNum(int[] nums)
        {
            double firstHalfLG = 0;
            double secondHalfLG = 0;
            if (nums.Length > 2)
            {
                firstHalfLG = nums.Take(nums.Length / 2).Average();
                secondHalfLG = nums.Skip(nums.Length / 2).Average();
            }
            if (firstHalfLG > secondHalfLG)
            {
                return firstHalfLG;
            }
            return secondHalfLG;
        }

        private static int Ex135(int[] nums)
        {
            return Math.Max(int.Parse(Math.Round(nums.Take(nums.Length / 2).Average()).ToString())
                , int.Parse(Math.Round(nums.Skip(nums.Length / 2).Average()).ToString()));
        }
    }
}
