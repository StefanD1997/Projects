using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(consecutiveArray(new int[] { 1, 3, 5, 6, 9 }));
            Console.WriteLine(consecutiveArray(new int[] { 0, 10 }));
        }

        //which will accept a list of integers and checks how many integers are needed to complete the range
        static int consecutiveArray(int[] nums)
        {
            Array.Sort(nums);
            int ctr = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                ctr += nums[i + 1] - nums[i] - 1;
            }
            return ctr;
        }
    }
}
