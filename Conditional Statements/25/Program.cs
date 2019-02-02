using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _25
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            asd:
            Console.WriteLine("---- Displaying Menu ----");
            Console.WriteLine();
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            Console.Write("Input : ");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------");
            Choice(choice);
            goto asd;
        }

        static void Choice(int n)
        {
            int x, y;
            double result = 0;

            switch (n)
            {
                case 1:
                    Console.WriteLine("x + y");
                    Console.WriteLine("Input First number : ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input Second number : ");
                    y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Result = {0}",result = x + y);
                    break;
                case 2:
                    Console.WriteLine("x - y");
                    Console.WriteLine("Input First number : ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input Second number : ");
                    y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Result = {0}", result = x - y);
                    break;
                case 3:
                    Console.WriteLine("x * y");
                    Console.WriteLine("Input First number : ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input Second number : ");
                    y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Result = {0}", result = x * y);
                    break;
                case 4:
                    Console.WriteLine("x / y");
                    Console.WriteLine("Input First number : ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input Second number : ");
                    y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Result = {0}", result = x / y);
                    break;
                case 5:
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
        }
    }
}
