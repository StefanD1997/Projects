using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_one_given_temperature_is_less_than_0_and_greater_100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckTemperatures(2, 10));
            Console.WriteLine(CheckTemperatures(-50, 150));
            Console.WriteLine(CheckTemperatures(50, 150));
        }

        static bool CheckTemperatures(int temp1, int temp2)
        {
            if (temp1 < 0 && temp2 > 100 || temp2 < 0 && temp1 > 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Another Example
        public static bool test(int temp1, int temp2)
        {
            return temp1 < 0 && temp2 > 100 || temp2 < 0 && temp1 > 100;
        }
    }
}
