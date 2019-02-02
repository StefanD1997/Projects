using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.Write("x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("z = ");
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Largest num {0}", Math.Max(x, Math.Max(y, z)));
            Console.WriteLine("Lowest num {0}", Math.Min(x, Math.Min(y, z)));

        }

        //find the largest and lowest values from three integer values
        
    }
}
