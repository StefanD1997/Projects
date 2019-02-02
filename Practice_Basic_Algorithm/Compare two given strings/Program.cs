using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_two_given_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = "Hello";
            //for (int i = 0; i < n.Length; i++)
            //{
            //    Console.WriteLine(n.Substring(i, 2));
            //}
            Console.WriteLine(CompareString("Helosa", "Heare"));
            Console.WriteLine(CompareString("Styefan", "Sfatny"));
        }

        //Compare two given strings and return the number of the positions where they contain the same length 2 substring
        static int CompareString(string str1, string str2)
        {
            var ctr = 0;
            for (var i = 0; i < str1.Length - 1; i++)
            {
                var firstString = str1.Substring(i, 2);
                for (var j = 0; j < str2.Length - 1; j++)
                {
                    var secondString = str2.Substring(j, 2);
                    if (firstString.Equals(secondString))
                        ctr++;
                }
            }
            return ctr;
        }
    }
}
