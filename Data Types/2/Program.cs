using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle(5, 10);
        }

        //that takes a number and a width also a number, as input and then displays a triangle of that width, using that number
        static void Triangle(int n, int w)
        {
            for (int i = 0; i < w;)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write(n);
                }
                Console.Write("\n");
                w -= 1;
            }
            
        }
    }
}
