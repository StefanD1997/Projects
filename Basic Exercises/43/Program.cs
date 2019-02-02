using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            Console.Write("String : ");
            x = Console.ReadLine();
            Console.WriteLine(ChechString(x));
        }

        //check if a given string starts with "w" and immediately followed by two "ww"
        static bool ChechString(string str)
        {
            if (str.Length > 2)
            {
                if (str.StartsWith("w") && str.Substring(1, 2) == "ww")
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
