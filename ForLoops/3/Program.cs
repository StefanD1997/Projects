using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Enter a number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Display(x);
        }

        //display n terms of natural number and their sum
        static int Display(int n)
        {
            int result = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i != 0)
                {
                    Console.WriteLine(i);
                    result += i;
                }
            }
            Console.WriteLine("Result is {0}", result);
            return result;
        }
    }
}
