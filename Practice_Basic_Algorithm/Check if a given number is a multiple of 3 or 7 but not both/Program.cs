using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_a_given_number_is_a_multiple_of_3_or_7_but_not_both
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckInts(21));
            Console.WriteLine(CheckNums(21)); 
        }

        //Check if a given non-negative given number is a multiple of 3 or 7, but not both
        static bool CheckInts(int n)
        {
            if (n % 3 == 0 && n % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Another Example
        static bool CheckNums(int n)
        {
            return n % 3 == 0 ^ n % 7 == 0;
        }
    }
}
