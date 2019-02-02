using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateTriangle();
        }

        //display the pattern like right angle triangle using an asterisk
        static void CreateTriangle()
        {
            int n = 1;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                n++;
            }
        }
    }
}
