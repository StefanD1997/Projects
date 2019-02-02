using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    class Program
    {
        static void Main(string[] args)
        {
            perfectNumbersInRange(1, 10000); 
        }

        // find the perfect numbers within a given range of number
        static void perfectNumbersInRange(int s, int e)
        {
            List<int> perfectNums = new List<int>();
            List<int> notPerfectNums = new List<int>();
            int divisionSum = 0, currNum;
            for (int i = s; i < e; i++)
            {
                currNum = i;
                int b = 1;
                divisionSum = 0;
                for (int j = b; j < currNum; j++)
                {
                    if (currNum % j == 0)
                    {
                        divisionSum += j;
                    }
                }
                if (divisionSum == currNum)
                {
                    perfectNums.Add(currNum);
                }
                else
                {
                    notPerfectNums.Add(currNum);
                }
            }

            Console.Write("Perfect Numbers are from {0} to {1}:", s, e);
            Console.Write("\n");
            foreach (int num in perfectNums)
            {
                Console.Write(num + " ");
            }
        }
    }
}
