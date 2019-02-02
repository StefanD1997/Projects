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
            int choice;
            Console.WriteLine("-----Displaying Menu-----");
            Console.WriteLine();

            Console.WriteLine("1. Area for circle");
            Console.WriteLine("2. Area for rectangle");
            Console.WriteLine("3. Area for triangle");
            Console.Write("Input : ");
            choice = Convert.ToInt32(Console.ReadLine());
            Choice(choice);


        }

        //Menu-Driven Program to compute the area of the various geometrical shape
        static void Choice(int c)
        {
            int r, l, w, b, h;
            double area = 0;

            switch (c)
            {
                case 1:
                    Console.WriteLine("Input radius of the cricle :");
                    r = Convert.ToInt32(Console.ReadLine());
                    area = 3.14 * r * r;
                    break;
                case 2:
                    Console.WriteLine("Input length of triangle : ");
                    l = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input width of triangle : ");
                    w = Convert.ToInt32(Console.ReadLine());
                    area = l * w;
                    break;
                case 3:
                    Console.WriteLine("Input base of the triangle : ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input the height of the triangle");
                    h = Convert.ToInt32(Console.ReadLine());
                    break;
            }

            Console.WriteLine("The are is : {0}", area);
        }
    }
}
