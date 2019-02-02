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
            int cnt = 0;
            int index = 1;
            List<int> mylist = new List<int>();
            do
            {
                int num;
                Console.Write("Enter {0} number : ", index);
                num = Convert.ToInt32(Console.ReadLine());
                mylist.Add(num);
                index++;
                cnt++;
            } while (cnt != 10);
            SumAndAverage(mylist);
        }

        //read 10 numbers from keyboard and find their sum and average
        static void SumAndAverage(List<int> list)
        {
            int result = 0;
            double average;
            result = list.Sum();
            average = list.Average();
            Console.WriteLine("Sum of the numbers is {0}", result);
            Console.WriteLine("Average is {0}", average);
        }
    }
}
