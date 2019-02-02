using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    class Program
    {
        static void Main(string[] args)
        {

            double x, sum, no_row, ctr;
            int i, n;

            Console.Write("\n\n");
            Console.Write("Calculate the sum of the series [ x - x^3 + x^5 - ......]:\n");
            Console.Write("------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the value of x :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = x; no_row = x;
            for (i = 1; i < n; i++)
            {
                ctr = (2 * i) * (2 * i + 1);
                no_row = -no_row * x * x / ctr;
                sum = sum + no_row;
            }
            Console.Write("\nThe sum = {0}\nNumber of terms = {1}\n The value of x = {2}\n", sum, n, x);
        }

        //find the sum of the series [ x - x^3 + x^5 + ......]
    }
}

