using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 5, 7, 8 };
            Console.WriteLine(LargestValueArray(nums));
        }

        //get the larger value between first and last element of an array(length 3) of integers
        static int LargestValueArray(int[] nums)
        {
            return nums.Max();
        }
    }
}
