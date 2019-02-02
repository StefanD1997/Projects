using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, k = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (k == 2)
                    {
                        k = 0;
                    }
                    Console.Write("{0} ", k++);
                }
                x++;
                Console.Write("\n");
            }
        }
        //print the Floyd's Triangle
    }
}
