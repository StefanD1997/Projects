using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace That_takes_a_number_as_input_and_print_its_multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int result;

            Console.WriteLine("Enter One Number");
            Console.WriteLine();
            Console.WriteLine("X = ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Press Any Key");
            Console.WriteLine();
            Console.WriteLine("{0} * {1} = {2}", x, 0, result = x * 0);
            Console.WriteLine("{0} * {1} = {2}", x, 1, result = x * 1);
            Console.WriteLine("{0} * {1} = {2}", x, 2, result = x * 2);
            Console.WriteLine("{0} * {1} = {2}", x, 3, result = x * 3);
            Console.WriteLine("{0} * {1} = {2}", x, 4, result = x * 4);
            Console.WriteLine("{0} * {1} = {2}", x, 5, result = x * 5);
            Console.WriteLine("{0} * {1} = {2}", x, 6, result = x * 6);
            Console.WriteLine("{0} * {1} = {2}", x, 7, result = x * 7);
            Console.WriteLine("{0} * {1} = {2}", x, 8, result = x * 8);
            Console.WriteLine("{0} * {1} = {2}", x, 9, result = x * 9);
            Console.WriteLine("{0} * {1} = {2}", x, 10, result = x * 10);
        }

        //Program that takes a number as input and print its multiplication table
    }
}
