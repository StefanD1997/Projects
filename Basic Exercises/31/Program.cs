using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 1, 3, -5, 4 };
            int[] secondArray = { 1, 4, -5, -2 };

            List<int> resultList = new List<int>();

            for (int j = 0; j < secondArray.Length; j++)
            {
                int numSecondArray = secondArray[j];
                int numFirstArray = firstArray[j];
                resultList.Add(numFirstArray * numSecondArray);

                foreach (int item in resultList)
                {
                    Console.WriteLine(item);
                }
            }
        }

        //multiply corresponding elements of two arrays of integers
    }
}
