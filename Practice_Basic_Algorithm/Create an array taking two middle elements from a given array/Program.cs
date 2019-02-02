using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_an_array_taking_two_middle_elements_from_a_given_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
            CreateArr(x);
        }

        //create an array taking two middle elements from a given array of integers of length even
        static int[] CreateArr(int[] nums)
        {
            int[] newArr = { nums[nums.Length / 2 - 1], nums[nums.Length / 2] };
            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }
            return newArr;
        }
    }
}
