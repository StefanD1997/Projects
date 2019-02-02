using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_the_output_of_multiplication_of_three_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1, int2, int3;
            int result;

            Console.WriteLine("You will need to enter three numbers.");
            Console.WriteLine("After you have been asked to enter the number press the number you want to assign and press enter.");
            Console.WriteLine("Press Enter to Continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {

            }
            Console.WriteLine();
            Console.WriteLine("First number for multiplying :");
            int1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number for multiplying :");
            int2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Thrid number for multiplying :");
            int3 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("{0}, {1}, {2}", int1, int2, int3);
            result = int1 + int2 + int3;
            Console.WriteLine("Result = {0}", result);
        }

        //print the output of multiplication of three numbers
    }
}
