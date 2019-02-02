using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 8, 5, 6, 4, 2, 3, 7, 8, 5, 6, 10, 2, 4 };
            int x;
            foreach (int item in nums)
            {
                Console.Write(item + " ");
            }
            Console.Write("\nx = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("There are {0} nums equal to {1}",CountNum(nums, x), x);
        }

        //count a specified number in a given array of integers
        static int CountNum(int[] nums, int n)
        {
            int cnt = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] ==  n)
                {
                    cnt++;
                }
            }

            return cnt;
        }
    }
}
