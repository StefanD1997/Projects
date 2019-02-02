using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_given_array_of_integers_and_length_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseArr(new[] { 5, 2, 7, 9, 6 }));
        }

        //reverse a given array of integers and length 5.
        static int[] ReverseArr(int[] nums)
        {
            Console.WriteLine("Array not reversed");
            foreach (int item in nums)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            nums.Reverse();
            Console.WriteLine("Array reversed");
            foreach (int item in nums.Reverse())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            return nums;
        }
    }
}
