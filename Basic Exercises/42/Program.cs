using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            Console.Write("String: ");
            x = Console.ReadLine();
            Console.WriteLine(CreateString(x));
        }

        //create a new string where the first 4 characters will be in lower case. If the string is less than 4 characters then make the whole string in upper case
        static string CreateString(string str)
        {
            if (str.Length < 4)
            {
                return str.ToUpper();
            }
            else
            {
                return str.Substring(0, 4).ToUpper() + str.Substring(4, str.Length - 4);
            }
        }
    }
}
