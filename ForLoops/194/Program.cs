using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += 1 / (float)i;
            }
            Console.WriteLine(result);
        }

        //display the n terms of harmonic series and their sum. The series is : 
        //1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms
    }
}
