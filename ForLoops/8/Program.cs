using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Enter a number : ");
            x = Convert.ToInt32(Console.ReadLine());
            nNumbers(x);
        }

        //display the n terms of odd natural number and their sum
        static void nNumbers(int n)
        {
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    result += i;
                }
            }
            Console.WriteLine("Sum of those numbers is {0}",result);
        }
    }
}
