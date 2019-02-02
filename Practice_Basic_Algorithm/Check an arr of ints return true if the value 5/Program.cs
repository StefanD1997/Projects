using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_an_arr_of_ints_return_true_if_the_value_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckArr(new[] { 3, 5, 1, 5, 3, 5, 7, 5, 1, 5 }));
            Console.WriteLine(CheckArr(new[] { 3, 5, 5, 5, 5, 5, 5 }));
            Console.WriteLine(CheckArr(new[] { 3, 5, 2, 5, 4, 5, 7, 5, 8, 5 }));
            Console.WriteLine(CheckArr(new[] { 2, 4, 5, 5, 5, 5 }));
        }

        //check a given array of integers and return true if the value 5 appears 5 times and there are no 5 next to each other
        static bool CheckArr(int[] nums)
        {
            int fives = 0;

            if (nums.Length > 5)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 5)
                    {
                        fives++;
                    }
                }

                for (int j = 0; j < nums.Length; j++)
                {
                    if (fives == 5 && nums[j] == 5 && nums[++j] != 5)
                    {
                        return true;
                    }
                }
            }
            Console.WriteLine(fives);
            return false;
        }

        //Another Example
        static bool test(int[] numbers)
        {
            bool flag = false;
            int five = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 5 && !flag)
                {
                    five++;
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }

            return five == 5;
        }
    }
}
