using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_str_taking_the_first_char_from_a_str
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateString("Hello", "Hi"));
            Console.WriteLine(CreateString("", ""));
            Console.WriteLine(CreateString("Python", "PHP"));
            Console.WriteLine(CreateString("JS", "JS"));
            Console.WriteLine(CreateString("Csharp", ""));
        }

        //create a new string taking the first character from a given string and the last character from another
        //given string. If the length of any given string is 0, use '#' as its missing character
        static string CreateString(string str, string str2)
        {
            if (str.Length <= 0 && str2.Length <= 0)
            {
                str = "#";
                str2 = "#";
                return str + str2;
            }
            else if (str.Length <= 0)
            {
                str = "#";
                return str + str2.Substring(str2.Length - 1);
            }
            else if (str2.Length <= 0)
            {
                str2 = "#";
                return str.Substring(0, 1) + str2;
            }
            else if (str.Length > 1 && str2.Length > 1)
            {
                return str.Substring(0, 1) + str2.Substring(str2.Length - 1);
            }
            return str;
        }
    }
}
