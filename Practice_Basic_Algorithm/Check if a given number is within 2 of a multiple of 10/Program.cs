using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_a_given_number_is_within_2_of_a_multiple_of_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckNum(20));
        }

        //Check if a given number is within 2 of a multiple of 10
        static bool CheckNum(int n)
        {
            if (n % 10 <= 2 || n % 10 >= 8)
            {
                return true;
            }
            return false;
        }

        //Another Example
        public static bool test(int n)
        {
            return n % 10 <= 2 || n % 10 >= 8;
        }
    }
}
