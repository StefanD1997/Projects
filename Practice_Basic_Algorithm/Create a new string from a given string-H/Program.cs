using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_string_from_a_given_string_H
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateString("abcab"));
            Console.WriteLine(CreateString("Python"));
            Console.WriteLine(CreateString("ab"));
            Console.WriteLine(CreateString("a"));
            Console.WriteLine(CreateString(""));
            Console.WriteLine(CreateString("StefanSt"));
        }

        //create a new string from a given string. If the two characters of the given string from its beginning
        //and end are same return the given string without the first two characters otherwise return the original string
        static string CreateString(string str)
        {
            if (str.Length > 2)
            {
                if (str.Substring(0, 2) == str.Substring(str.Length - 2))
                {
                    return str.Substring(2);
                }
            }
            return str;
        }
    }
}
