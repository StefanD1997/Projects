using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            int result;
            Console.WriteLine("Enter Three Numbers");
            Console.WriteLine();
            Console.Write("x = ");
            x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            y = int.Parse(Console.ReadLine());
            Console.Write("z = ");
            z = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Formula (x + y) * z");
            Console.WriteLine("Result: {0}", result = (x + y) * z);
            Console.WriteLine();
            Console.WriteLine("Formula x * y + y * z");
            Console.WriteLine("Result: {0}", result = x * y + y * z);
        }

        //program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z
    }
}
