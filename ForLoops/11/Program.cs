using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
                n++;
            }
        }

        //make such a pattern like right angle triangle with a number which will repeat a number in a row
    }
}
