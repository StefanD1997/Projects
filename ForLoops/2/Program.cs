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
            int result = 0;
            // find the sum of first 10 natural numbers
            for (int i = 0; i < 11; i++)
            {
                if (i != 0)
                {
                    Console.WriteLine(i);
                    result += i;
                }
            }
            Console.WriteLine("The result is {0}", result);
        }
    }
}
