using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_a_given_arr__len_atleast_2__of_integers_and_return
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckArr(new[] { 5, 5, 1, 15, 15 }));
            Console.WriteLine(CheckArr(new[] { 15, 2, 3, 4, 15 }));
            Console.WriteLine(CheckArr(new[] { 3, 3, 15, 15, 5, 5 }));
            Console.WriteLine(CheckArr(new[] { 1, 5, 15, 7, 8, 15 }));
        }

        //check a given array (length will be atleast 2) of integers and return true if there are two values 
        //15, 15 next to each other
        static bool CheckArr(int[] nums)
        {
            if (nums.Length > 2)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] == 15 && nums[i + 1] == 15)
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
        }
    }
}
