using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takes_four_numbers_as_input_to_calculate_and_print_the_average
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1, int2, int3, int4;
            int average;
            Console.WriteLine("Enter Four Numbers");
            Console.WriteLine();
            Console.WriteLine("First Number :");
            int1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second Number :");
            int2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Thrid Number :");
            int3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Fourth Number :");
            int4 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("The Average Number Is: {0}", average = (int1 + int2 + int3 + int4) / 4);
        }

        //Program that takes four numbers as input to calculate and print the average
    }
}
