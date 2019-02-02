using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.Write("Enter the 1st number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd number : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 3rd number : ");
            z = Convert.ToInt32(Console.ReadLine());
            FindTheLargestNumber(x, y, z);
        }

        //find the largest of three numbers
        static void FindTheLargestNumber(int x, int y, int z)
        {
            Console.WriteLine("The largest number is {0}", Math.Max(x, Math.Max(y, z)));
        }
    }
}
