using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    class Program
    {
        static void Main(string[] args)
        {
            naturalSquare(5);
        }

        //display the n terms of square natural number and their sum
        static void naturalSquare(int n)
        {
            List<double> list = new List<double>();

            for (int i = 0; i <= n; i++)
            {
                if (i != 0)
                {
                    list.Add(Math.Pow(i, 2));
                }
            }
            foreach (double item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sum is {0}", list.Sum());
        }
    }
}
