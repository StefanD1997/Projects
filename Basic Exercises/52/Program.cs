using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 5 };
            int[] array2 = { 0, 3, 8 };
            int[] array3 = { -1, 0, 2 };
            Console.WriteLine(NewArray(array1, array2, array3));
        }

        //create a new array of length containing the middle elements of three arrays (each length 3) of integers
        static int[] NewArray(int[] nums, int[] nums1, int[] nums2)
        {
            int[] array = new int[3];
            array[0] = nums[1];
            array[1] = nums1[1];
            array[2] = nums2[1];

            foreach (int item in array)
            {
                Console.WriteLine(item  );
            }

            return array;
        }
    }
}
