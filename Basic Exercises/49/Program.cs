using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int[] nums2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
            Console.WriteLine(CheckTwoArrays(nums1, nums2));
        }

        //check if the first element or the last element of the two arrays ( length 1 or more) are equal
        static bool CheckTwoArrays(int[] nums, int[] nums1)
        {
            return nums[0] == nums1[0] && nums[nums.Length - 1] == nums1[nums1.Length - 1];
        }
    }
}
