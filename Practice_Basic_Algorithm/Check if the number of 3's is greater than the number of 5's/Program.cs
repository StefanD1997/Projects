using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_the_number_of_3_s_is_greater_than_the_number_of_5_s
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckArr(new[] { 1, 5, 6, 9, 3, 3 }));
            Console.WriteLine(CheckArr(new[] { 1, 5, 5, 5, 10, 17 }));
            Console.WriteLine(CheckArr(new[] { 1, 3, 3, 5, 5, 5 }));
        }

        //check if the number of 3's is greater than the number of 5's
        static bool CheckArr(int[] nums)
        {
            int count3 = 0;
            int count5 = 0;
            foreach (int item in nums)
            {
                if (item == 5)
                {
                    count5 += 1;
                }
                else if (item == 3)
                {
                    count3 += 1;
                }
                else
                {

                }
            }

            return count3 > count5;
        }
    }
}
