using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            int x;
            foreach (int item in nums)
            {
                Console.Write(item + " ");
            }
            Console.Write("\nx = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CheckArray(nums, x));
        }

        //check if a number appears as either the first or last element of an array of integers and the length is 1 or more
        static bool CheckArray(int[] nums, int x)
        {
            if (nums.Length > 2)
            {
                if (nums[0] == x || nums[nums.Length - 1] == x)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
