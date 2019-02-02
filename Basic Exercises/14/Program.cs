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
            //kelvin = celsius + 273 
            //fahrenheit = celsius x 18 / 10 + 32
            int x, result;
            
            Console.Write("Enter Celsius : ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Kelvin = {0}", result = x + 273);
            Console.WriteLine("Fahrenheit = {0}", result = x * 18 / 10 + 32);

        }

        //convert from celsius degrees to Kelvin and Fahrenheit.
    }
}
