using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.Write("Enter radius of circle : ");
            num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(calculateAreaOfCircle(num));
        }

        //that takes the radius of a circle as input and calculate the perimeter and area of the circle
        static double calculateAreaOfCircle(double r)
        {
            double result;
            const double pi = 3.14159;
            result = 2 * pi * r;
            return result;
        }
    }
}
