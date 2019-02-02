using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_array_of_integers_and_length_1_or_more
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 10, 20, 30, 40, 50, 80 , 51, 54 };
            CreateArr(x);
        }

        //create a new array of integers and length 1 or more. The length of the new array will be double
        //length of an given array and all the elements are 0 except the first  element which is equal to
        //first elements of the given array.
        static int[] CreateArr(int[] nums)
        {
                int[] newArr = new int[nums.Length * 2];
                for (int i = 0; i < newArr.Length; i++)
                {
                    newArr[0] = nums[0];
                    newArr[++i] = 0;
                }
                foreach (var item in newArr)
                {
                    Console.WriteLine(item);
                }
                return newArr;
        }
    }
}
