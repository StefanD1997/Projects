using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Enter a number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Qubes(x);
        }

        //display the cube of the number upto given an integer
        static void Qubes(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i != 0)
                {
                    Console.WriteLine("Number is {0}, and qube for that number is {1}", i, Math.Pow(i, 3));
                }
            }
        }
    }
}
