using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_arr_using_the_first_n_strings_from_a_given_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] item = NewArr(new[] { "a", "b", "bb", "c", "ccc" }, 3);
        }

        //create a new array using the first n strings from a given array of strings. (n>=1 and <=length of the array)
        static string[] NewArr(string[] arr, int len)
        {
            List<string> newStrArr = new List<string>();
            for (int i = 0; i < len; i++)
            {
                newStrArr.Add(arr[i]);
            }
            foreach (var item in newStrArr)
            {
                Console.WriteLine(item);
            }
            return newStrArr.ToArray();
        }
    }
}
