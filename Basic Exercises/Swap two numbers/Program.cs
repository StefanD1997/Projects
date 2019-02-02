using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1, int2, int3;
            Console.WriteLine("Input first number : ");
            int1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second number : ");
            int2 = int.Parse(Console.ReadLine());
            int3 = int1;
            int1 = int2;
            int2 = int3;
            Console.WriteLine("Press Enter to Swap");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                
            }
            Console.WriteLine("After Swapping");
            Console.WriteLine("First Number : " + int1);
            Console.WriteLine("Second Number : " + int2);

        }

        //swap two numbers
    }
}
