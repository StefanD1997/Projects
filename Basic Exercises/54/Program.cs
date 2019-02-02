using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(centuryFromYear(2019)); 
        }

        //get the century from a year
        static int centuryFromYear(int year)
        {
            return (year / 100) + ((year % 100 == 0) ? 0 : 1);
        }
    }
}
