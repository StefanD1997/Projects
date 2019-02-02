using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("Enter a year : ");
            year = Convert.ToInt32(Console.ReadLine());
            CheckIfLeapYear(year);
        }

        //find whether a given year is a leap year or not
        static void CheckIfLeapYear(int year)
        {
            if (year %  400 == 0)
            {
                Console.WriteLine("{0} is a leap year", year);
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("{0} is not a leap year", year);
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("{0} is a leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is not leap year", year);
            }
        }
    }
}
