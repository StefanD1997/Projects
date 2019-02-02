using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_a_positive_int_and_return_if_it_contains_a_number_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckInt(123));
            Console.WriteLine(CheckInt(13));
            Console.WriteLine(CheckInt(222));
        }

        //check a positive integer and return true if it contains a number 2
        static bool CheckInt(int n)
        {
            return n.ToString().Contains("2");
        }

        //Another Example
        public static bool test(int n)
        {
            while (n > 0)
            {
                if (n % 10 == 2) return true;
                n /= 10;
            }
            return false;
        }
    }
}
