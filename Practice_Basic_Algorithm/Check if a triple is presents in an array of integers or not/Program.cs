using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_a_triple_is_presents_in_an_array_of_integers_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 8, 4, 6, 5, 4, 4, 4 };
            Console.WriteLine(CheckForTriplet(arr));
            Console.WriteLine(test(arr));
        }

        static bool CheckForTriplet(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int x = arr[i];
                if (arr[i].Equals(x) && arr[i + 1].Equals(x) && arr[i + 2].Equals(x))
                {
                    return true;
                }
            }
            return false;
        }

        //Another Example
        public static bool test(int[] nums)
        {
            int arra_len = nums.Length - 1, n = 0;
            for (int i = 0; i < arra_len; i++)
            {
                n = nums[i];
                if (n == nums[i + 1] && n == nums[i + 2]) return true;
            }
            return false;
        }
    }
}
