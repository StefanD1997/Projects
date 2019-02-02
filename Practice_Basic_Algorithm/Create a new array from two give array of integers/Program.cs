using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_array_from_two_give_array_of_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 10, 20, 30 };
            int[] z = { 30, 20, 30 };
            CreateArr(x, z);
        }

        static int[] CreateArr(int[] nums, int[] nums2)
        {
            int[] newArray = new int[nums.Length + nums2.Length];
            Array.Copy(nums, newArray, nums.Length);
            Array.Copy(nums2, 0, newArray, nums.Length, nums2.Length);
            foreach (int item in newArray)
            {
                Console.WriteLine(item);
            }
            return newArray;



        }
    }
}
