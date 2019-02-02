using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_num_of_strs_with_length_in_given_array_of_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Count(new[] { "a", "b", "bb", "c", "ccc" }, 5));
        }

        //count the number of strings with given length in given array of strings
        static int Count(string[] arr, int len)
        {
            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == len)
                {
                    cnt++;
                }
            }
            return cnt;
        }
    }
}
