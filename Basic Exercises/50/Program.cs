using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 8, 1 };
            Console.WriteLine(RotateArrayLeft(nums));
        }

        //rotate the elements an array (length 3) of integers in left direction
        static int[] RotateArrayLeft(int[] nums)
        {
            int temp = nums[0];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                nums[i] = nums[i + 1];
            }
            nums[nums.Length - 1] = temp;

            foreach (int item in nums)
            {
                Console.WriteLine(item);
            }
            return nums;
        }
    }
}
