using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_number_of_two_5_s_that_are_next_to_each_other
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 5, 4, 5, 8, 5, 6, 5, 5, 8, 9};
            Console.WriteLine(Count(arr));
        }

        static int Count(int[] arr)
        {
            int cnt = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == 5 && arr[i + 1] == 5 || arr[i + 1] == 6)
                {
                    cnt++;
                }
                cnt += 0;
            }
            return cnt;
        }

        //Another Example
        public static int test(int[] numbers)
        {
            var ctr = 0;
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i].Equals(5) && (numbers[i + 1].Equals(5) || numbers[i + 1].Equals(6))) ctr++;
            }
            return ctr;
        }
    }
}
