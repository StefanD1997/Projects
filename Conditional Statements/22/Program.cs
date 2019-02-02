using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a month in a number : ");
            n = Convert.ToInt32(Console.ReadLine());
            monthNumber(n);
        }

        //read any Month Number in integer and display Month name in the word
        static void monthNumber(int n)
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            if (n > 0 && n <= 12)
            {
                Console.WriteLine(months[n - 1]);
            }
            else
            {
                Console.WriteLine("Invalid month number");
            }
        }
    }
}
