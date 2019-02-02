using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Enter a number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("One nume must be in range -10 to 10");
            Console.WriteLine(CheckNums(x, y));
        }

        //check if an integer (from the two given integers) is in the range -10 to 10
        static bool CheckNums(int x, int y)
        {
            return (x > -10 && x < 10) || (y > -10 && y < 10);
        }
    }
}
