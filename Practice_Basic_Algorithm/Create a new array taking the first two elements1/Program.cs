using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_array_taking_the_first_two_elements1
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine(CreateArr(new[] {1}));
              Console.WriteLine(CreateArr(new[] {1,2,9}));
              Console.WriteLine(CreateArr(new[] {1,2,9,3,3}));
        }

        //create a new array taking the first two elements from a given array. If the length of the given array
        //is less than 2 then return the give array
        static int[] CreateArr(int[] nums)
        {
            if (nums.Length <= 2)
            {
                foreach (int item in nums)
                {
                    Console.WriteLine(item);
                }
                return nums;
            }
            else
            {
                int[] newArr = new int[2];
                newArr[0] = nums[0];
                newArr[1] = nums[1];
                foreach (int item in newArr)
                {
                    Console.WriteLine(item);
                }
                return newArr;
            }
        }

        //Another Example
        private static int[] Ex108(int[] x)
        {
            return x.Length < 2 ? x : new int[] { x[0], x[1] };
        }

    }
}
