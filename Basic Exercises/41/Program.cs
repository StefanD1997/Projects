using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            Console.Write("Sentence : ");
            x = Console.ReadLine();
            Console.WriteLine(CountW(x));
        }

        //check if a given string contains ‘w’ character between 1 and 3 times
        static bool CountW(string str)
        {
            int cnt = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'w')
                {
                    cnt++;
                }
            }
            return cnt > 0 && cnt <= 3;
        }

        ////Another Example
        //Console.Write("Input a string (conatins at least one 'w' char) : ");
        //string str = Console.ReadLine();
        //var count = str.Count(s => s == 'e');
        //Console.WriteLine("Test the string contains 'w' character  between 1 and 3 times: ");
        //Console.WriteLine(count>=1 && count <= 3)
    }
}
