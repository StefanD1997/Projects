using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_a_given_string_starts_with_CSharp_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Check_If_String_Contains_CSharp("C# yeah"));
            Console.WriteLine(Check_If_String_Contains_CSharp("yeah"));
            Console.WriteLine(Check_If_String_Contains_CSharp("C#yeah"));
        }

        static bool Check_If_String_Contains_CSharp(string str)
        {
            if (str.Length > 1)
            {
                if (str.Substring(0, 2).Equals("C#"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        //Another Example
        public static bool test(string str)
        {
            return (str.Length < 3 && str.Equals("C#")) || (str.StartsWith("C#") && str[2] == ' ');
        }
    }
}
