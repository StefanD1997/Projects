using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_a_given_positive_number_is_a_multiple_of_3_or_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Check_If_Number_Is_Multiple_Of_3_Or_7(5));
            Console.WriteLine(Check_If_Number_Is_Multiple_Of_3_Or_7(3));
            Console.WriteLine(Check_If_Number_Is_Multiple_Of_3_Or_7(7));
            Console.WriteLine(Check_If_Number_Is_Multiple_Of_3_Or_7(-2));
        }

        static bool Check_If_Number_Is_Multiple_Of_3_Or_7(int n)
        {
            if (n % 3 == 0 || n % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool test(int n)
        {
            return n % 3 == 0 || n % 7 == 0;
        }
    }
}
