using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string operation;
            Console.WriteLine("--------------");
            Console.Write("Enter a number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a operation : ");
            operation = Console.ReadLine();
            if (operation == "+")
            {
                Console.WriteLine(x + y);
            }
            else if (operation == "-")
            {
                Console.WriteLine(x - y);
            }
            else if (operation == "*")
            {
                Console.WriteLine(x * y);
            }
            else if (operation == "/")
            {
                Console.WriteLine(x / y);
            }
            else
            {
                Console.WriteLine("Wrong chracter");
            }
        }

        //that takes two numbers as input and perform an operation (+,-,*,x,/) on them and displays the result of that operation
    }
}
