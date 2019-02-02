using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shift_an_element_in_left_direction_and_return_a_new_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] item = NewArr(new[] { 10, 20, -30, -40, 50, 80, 502, 45 });
        }

        //shift an element in left direction and return a new array
        static int[] NewArr(int[] nums)
        {
            int firstNum = nums[0];
            Array.Copy(nums, 1, nums, 0, nums.Length - 1);
            nums[nums.Length - 1] = firstNum;
            foreach (int item in nums)
            {
                Console.WriteLine(item);
            }
            return nums;
        }
    }
}
