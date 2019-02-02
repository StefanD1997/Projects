using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_an_arr_of_ints_return_if_the_arr_has_2_even
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckArr(new[] { 3, 5, 1, 3, 7 }));
            Console.WriteLine(CheckArr(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(CheckArr(new[] { 3, 3, 5, 5, 5, 5 }));
            Console.WriteLine(CheckArr(new[] { 2, 4, 5, 6 }));
        }

        //heck a given array of integers and return true if the given array contains either 2 even or 2 odd
        //values all next to each other
        static bool CheckArr(int[] nums)
        {
            int evenNums = 0;
            int oddNums = 0;
            if (nums.Length >= 2)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (evenNums < 2 && oddNums < 2)
                    {
                        if (nums[i] % 2 == 0)
                        {
                            evenNums++;
                            oddNums = 0;
                        }
                        else
                        {
                            oddNums++;
                            evenNums = 0;
                        }
                    }
                }
            }
            return evenNums == 2 || oddNums == 2;
        }
    }
}
