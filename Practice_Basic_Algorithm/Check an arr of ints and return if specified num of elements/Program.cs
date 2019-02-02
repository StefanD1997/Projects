using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_an_arr_of_ints_and_return_if_specified_num_of_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 3, 7, 5, 5, 3, 7 }, 2));
            Console.WriteLine(test(new[] { 3, 7, 5, 5, 3, 7 }, 3));
            Console.WriteLine(test(new[] { 3, 7, 5, 5, 3, 7, 5 }, 3));
        }

        //check a given array of integers and return true if the specified number of same elements appears at the
        //start and end of the given array
        static bool test(int[] numbers, int len)
        {
            int arra_size = numbers.Length;

            for (int i = 0; i < len; i++)
            {
                if (numbers[i] != numbers[arra_size - len + i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
