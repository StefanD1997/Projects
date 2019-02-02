using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_the_output_of_adding__subtracting__multiplying_and_dividing
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1, int2;

            Console.WriteLine("Enter Two Numbers");
            Console.WriteLine();
            Console.WriteLine("First Number : ");
            int1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second Number : ");
            int2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("{0} + {1} = {2}", int1, int2, int1 + int2);
            Console.WriteLine("{0} - {1} = {2}", int1, int2, int1 - int2);
            Console.WriteLine("{0} * {1} = {2}", int1, int2, int1 * int2);
            Console.WriteLine("{0} / {1} = {2}", int1, int2, int1 / int2);
        }

        //print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user
    }
}
