using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Enter temp in centigrade : ");
            x = Convert.ToInt32(Console.ReadLine());
            readTemperature(x);
        }

        //read temperature in centigrade and display a suitable message according to temperature state below
        static void readTemperature(int t)
        {
            /*Temp < 0 then Freezing weather 
            Temp 0-10 then Very Cold weather
            Temp 10-20 then Cold weather
            Temp 20-30 then Normal in Temp 
            Temp 30-40 then Its Hot 
            Temp >=40 then Its Very Hot */

            if (t < 0)
            {
                Console.WriteLine("Freezing weather");
            }
            else if (t <= 10)
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (t <= 20)
            {
                Console.WriteLine("Cold weather");
            }
            else if (t <= 30)
            {
                Console.WriteLine("Normal weather");
            }
            else if (t <= 40)
            {
                Console.WriteLine("Hot weather");
            }
            else
            {
                Console.WriteLine("Very Hot weather");
            }
        }
    }
}
