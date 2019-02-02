using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("{0} {0} {0} {0}", x);
            Console.WriteLine("{0}{0}{0}{0}", x);

        }

        //that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}
    }
}
