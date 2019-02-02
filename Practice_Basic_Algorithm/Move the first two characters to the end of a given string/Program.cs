using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_the_first_two_characters_to_the_end_of_a_given_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstTwoCharMoveAtEnd("Hello"));
            Console.WriteLine(FirstTwoCharMoveAtEnd("JS"));
        }

        //move the first two characters to the end of a given string of length at least two
        static string FirstTwoCharMoveAtEnd(string str)
        {
            if (str.Length > 2)
            {
                string firstTwoChars = str.Substring(0, 2);
                return str.Substring(2, str.Length - 2) + firstTwoChars;
            }
            return str;
        }

        //Another Example
        public static string test(string s1)
        {
            return s1.Remove(0, 2) + s1.Substring(0, 2);
        }
    }
}
