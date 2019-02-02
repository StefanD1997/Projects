using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnSumOfTwoIntegers_Triple_the_Sum_Ints_Same_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int input1 = Convert.ToInt32(Console.ReadLine());

            if (input == input1)
            {
                Console.WriteLine((input + input1) * 3);
            }
            else
            {
                Console.WriteLine(input + input1);
            }
        }

        public static int test(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
    }
}
