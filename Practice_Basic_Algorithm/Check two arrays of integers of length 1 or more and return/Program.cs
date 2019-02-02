using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_two_arrays_of_integers_of_length_1_or_more_and_return
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckArrs(new[] { 10, 20, 40, 50 }, new[] { 10, 20, 40, 50 }));
            Console.WriteLine(CheckArrs(new[] { 10, 20, 40, 50 }, new[] { 10, 20, 40, 5 }));
            Console.WriteLine(CheckArrs(new[] { 10, 20, 40, 50 }, new[] { 1, 20, 40, 5 }));
        }

        //check two given arrays of integers of length 1 or more and return true if they have the same first
        //element or they have the same last element
        static bool CheckArrs(int[] nums, int[] nums2)
        {
            return nums[0] == nums2[0] || nums[nums.Length - 1] == nums2[nums2.Length - 1];
        }
    }
}
