using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Enter a coordinate : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a  second coordinate : ");
            y = Convert.ToInt32(Console.ReadLine());
            coordinates(x, y);
        }

        //accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies
        static void coordinates(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("{0} and {1} are in the 1st quadrant", x, y);
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("{0} and {1} are in the 3rd quadrant", x, y);
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("{0} and {1} are in the 2nd quadrant", x, y);
            }
            else if (y > 0 && x < 0)
            {
                Console.WriteLine("{0} and {1} are in the 4th quadrant", x, y);
            }
            else
            {
                Console.WriteLine("{0} and {1} are in the origin", x, y);
            }
        }
    }
}
