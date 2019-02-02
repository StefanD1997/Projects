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
            int x, y, z;
            Console.Write("Enter a number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number : ");
            z = Convert.ToInt32(Console.ReadLine());
            QuadraticEquation(x, y, z);
        }

        //calculate root of Quadratic Equation
        static void QuadraticEquation(int x, int y, int z)
        {
            double d, x1, x2;

            d = y * y - 4 * x * z;

            if (d == 0)
            {
                Console.WriteLine("Both roots are equal");
                x1 = -y / (2.0 * x);
                x2 = x1;
                Console.WriteLine("First root Root1 =  {0}", x1);
                Console.WriteLine("Second root Root2 =  {0}", x2);
            }
            else if (d > 0)
            {
                Console.WriteLine("Both roots are real and diff -2");

                x1 = (-y + Math.Sqrt(d) / (2 * x));
                x2 = (-y - Math.Sqrt(d) / (2 * x));

                Console.WriteLine("First root Root1 =  {0}", x1);
                Console.WriteLine("Second root Root2 =  {0}", x2);
            }
            else
            {
                Console.WriteLine("Root are imeainary\n No solution");
            }
        }
    }
}
