using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_the_last_two_characters_to_the_start_of_a_given_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LastTwoCharsAtStart("Hello"));
            Console.WriteLine(LastTwoCharsAtStart("JS"));
        }

        //move the last two characters to the start of a given string of length at least two
        static string LastTwoCharsAtStart(string str)
        {
            if (str.Length > 2)
            {
                return str.Substring(str.Length - 2) + str.Remove(str.Length - 2);
            }
            return str;
        }
    }
}
