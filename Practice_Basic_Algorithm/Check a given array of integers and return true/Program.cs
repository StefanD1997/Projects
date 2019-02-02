using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_a_given_array_of_integers_and_return_true
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckArr(new[] { 5, 5, 1, 5, 5 }));
            Console.WriteLine(CheckArr(new[] { 1, 2, 3, 4 }));
            Console.WriteLine(CheckArr(new[] { 3, 3, 5, 5, 5, 5 }));
            Console.WriteLine(CheckArr(new[] { 1, 5, 5, 7, 8, 10 }));
        }

        //check a given array of integers and return true if the given array contains two 5's next to each other, 
        //or two  5 separated by one element
        static bool CheckArr(int[] nums)
        {
            if (nums.Length > 2)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 5 && nums[i + 1] == 5 || nums[i] == 5 && nums[i + 2] == 5)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
