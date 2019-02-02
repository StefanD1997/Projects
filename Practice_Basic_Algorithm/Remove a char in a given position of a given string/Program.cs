using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_a_char_in_a_given_position_of_a_given_string
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveChar("Hello", 2);
            RemoveChar("Hello", 1);
        }

        static void RemoveChar(string str, int n)
        {
            Console.Write(str.Remove(n, 1)+"\n");
        }
    }
}
