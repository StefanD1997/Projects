using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_array_taking_the_first_and_last_elements_in_arr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 100, 50, 60, 40, 25, 84, 52, 5020 };
            CreateArr(x);
        }

        //create a new array taking the first and last elements of a given array of integers and length 1 or more
        static int[] CreateArr(int[] nums)
        {
                int[] newArr = { nums[0], nums[nums.Length - 1] };
                foreach (var item in newArr)
                {
                    Console.WriteLine(item);
                }
                return newArr;
        }
    }
}
