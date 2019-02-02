using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;
            Console.Write("Enter month in number : ");
            month = Convert.ToInt32(Console.ReadLine());
            DaysInMonth(month);
        }

        //read any Month Number in integer and display the number of days for this month
        static int DaysInMonth(int month)
        {
            DateTime year = DateTime.Now;
            string m = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
            int x = DateTime.DaysInMonth(year.Year, month);
            Console.WriteLine("{0} has {1} days", m, x);
            return x;
        }
    }
}
