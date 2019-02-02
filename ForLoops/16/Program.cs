using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOfEvenNums(10);
        }

        //display the n terms of even natural number and their sum
        static void SumOfEvenNums(int n)
        {
            int result = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    result += i;
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n");

            Console.WriteLine("Result is {0}", result);
        }
    }
}
