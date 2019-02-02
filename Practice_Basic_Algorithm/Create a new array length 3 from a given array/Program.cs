using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_array_length_3_from_a_given_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 10, 20, 30, 40, 50, 60 };
            CreateArr(x);
        }

        //create a new array length 3 from a given array (length atleast 3) using the elements from the middle of the array
        static int[] CreateArr(int[] nums)
        {
            int middleMiddle1 = nums[nums.Length / 2];
            int middleMiddle0 = nums[nums.Length / 2 - 1];
            int middleMiddle2 = nums[nums.Length / 2 + 1];
            if (nums.Length >= 3)
            {
                int[] array = new int[3];
                array[0] = middleMiddle0;
                array[1] = middleMiddle1;
                array[2] = middleMiddle2;
                foreach (int item in array)
                {
                    Console.WriteLine(item);
                }
                return array;
            }
            return nums;
        }
    }
}
