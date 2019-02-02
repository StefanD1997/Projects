using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_an_ar_of_ints_and_return_true_if_the_array_contains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckArr(new[] { 1, 2, 3, 5, 3, 7 }));
            Console.WriteLine(CheckArr(new[] { 3, 7, 5, 5, 3, 7 }));
            Console.WriteLine(CheckArr(new[] { 3, 7, 5, 5, 6, 7, 5 }));
        }

        //check a given array of integers and return true if the array contains three increasing adjacent numbers
        static bool CheckArr(int[] nums)
        {
            int cnt = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] + 1 == nums[++i])
                {
                    cnt++;
                    return true;
                }
            }
            return cnt >= 3;
        }

        //Another Example
        static bool test(int[] numbers)
        {
            for (int i = 0; i <= numbers.Length - 3; i++)
            {
                if (numbers[i] == numbers[i + 1] - 1
                    && numbers[i] == numbers[i + 2] - 2)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
