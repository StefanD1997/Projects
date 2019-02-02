using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 4, 10, 8, 12 };
            Console.WriteLine(CheckOddNum(nums));
        }

        //check if an array contains an odd number.
        static bool CheckOddNum(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
