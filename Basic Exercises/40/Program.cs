using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(Near20(x, y));
        }

        static int Near20(int x, int y)
        {
            if (x == y)
            {
                return 0;
            }
            else if (Math.Abs(x - 20) > Math.Abs(y - 20))
            {
                return y;
            }
            else
            {
                return x;
            }
        }
    }
}
