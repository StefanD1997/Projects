using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_a_given_string_into_middle_of_the_another_given_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(InsertString("[[]]", "Hello"));
            Console.WriteLine(InsertString("(())", "Hi"));
            Console.WriteLine(InsertString("(())", "Hi"));
        }

        //Insert a given string into middle of the another given string of length 4
        static string InsertString(string str, string insertStr)
        {
            return str.Substring(0, 2) + insertStr + str.Substring(2);
        }
    }
}
