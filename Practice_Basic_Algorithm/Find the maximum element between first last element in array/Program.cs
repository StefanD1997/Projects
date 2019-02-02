using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_maximum_element_between_first_last_element_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = { 10, 20, -30, -40 };
            LargestNum(integers); 
        }

        //program to find out the maximum element between the first or last element in a given array of integers
        //(length 4), replace all elements with maximum element
        static int[] LargestNum(int[] nums)
        {
            int largets = nums.Max();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = largets;
                Console.WriteLine(nums[i]);
            }
            return nums;
        }
    }
}
