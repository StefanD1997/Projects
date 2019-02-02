using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Enter side a of the triangle : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter side b of the triangle : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter side c of the triangle : ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            CheckTriangle(a, b, c);
        }

        //check whether a triangle is Equilateral, Isosceles or Scalene
        static void CheckTriangle(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Equilateral Triangle");
            }
            else if (a == b || b == c || c == a)
            {
                Console.WriteLine("Isoscelas Triangle");
            }
            else
            {
                Console.WriteLine("Scalene Triangle");
            }
        }
    }
}
