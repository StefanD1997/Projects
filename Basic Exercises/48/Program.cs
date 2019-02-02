using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine(CheckArray(nums));
        }

        //check if the first element and the last element are equal of an array of integers and the length is 1 or more
        static bool CheckArray(int[] nums)
        {
            return nums[0] == nums[nums.Length - 1];
        }
    }
}
