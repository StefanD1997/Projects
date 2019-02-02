using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckIfPerfect(6);
        }

        //check whether a given number is perfect number or not
        static void CheckIfPerfect(int n)
        {
            List<int> list = new List<int>();
            int sum;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    list.Add(i);
                }
            }
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            sum = list.Sum();
            if (sum == n)
            {
                Console.WriteLine("Sum {0} is equal to {1}", sum, n);
            }
            else
            {
                Console.WriteLine("Sum {0} is not equal to {1}", sum, n);
            }
        }
    }
}
