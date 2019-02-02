using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            Console.Write("String : ");
            x = Console.ReadLine();
            Console.WriteLine(StringOddPositions(x));
        }

        //create a new string of every other character (even position) from the first position of a given string
        static string StringOddPositions(string str)
        {
            string x = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    x += str[i];
                }
            }
            return x;
        }
    }
}
