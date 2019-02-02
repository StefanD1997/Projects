using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_new_arr_of_given_len_using_the_odd_nums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NewArr(new[] { 1, 2, 3, 4, 5, 6, 7 }, 3));
        }

        //create a new array of given length using the odd numbers from a given array of positive integers
        static int[] NewArr(int[] nums, int n)
        {
            List<int> arrList = new List<int>();
            int cnt = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    if (cnt != n)
                    {
                        arrList.Add(nums[i]);
                        cnt++;
                    }
                    else
                    {
                        break;
                    }
                    
                }
                else
                {
                    nums.Skip(nums[i]);
                }
            }
            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }
            return arrList.ToArray();
        }
    }
}
