using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_arr_from_a_arr_of_str_using_all_the_strs
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = NewArr(new[] { "a", "aaa", "b", "bbb", "c", "ccc" }, 3);
        }

        //create a new array from a given array of strings using all the strings whose length are matched with given string length
        static string[] NewArr(string[] str, int len)
        {
            List<string> newStr = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length == len)
                {
                    newStr.Add(str[i]);
                }
            }
            foreach (var item in newStr)
            {
                Console.WriteLine(item);
            }
            return newStr.ToArray();
        }

        //Another Example
        static ArrayList test(string[] arr_str, int n)
        {
            ArrayList result_arra = new ArrayList();
            for (int i = 0; i < arr_str.Length; i++)
            {
                if (arr_str[i].Length == n)
                {
                    result_arra.Add(arr_str[i]);
                }
            }
            return result_arra;
        }
    }
}
