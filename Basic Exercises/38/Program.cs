using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "PHP Tutorial";
            Console.WriteLine(GetString(x));
        }

        //get a new string of two characters from a given string. The first and second character of the given string must be "P" and "H", so PHP will be "PH"
        static string GetString(string str)
        {
            if (str.Substring(0,2) == "PH" || str.Substring(0,2) == "ph")
            {
                return str.Substring(0, 2);
            }
            return str;
        }
    }
}
