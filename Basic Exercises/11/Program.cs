using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("You look older than {0}", age);
        }

        // that takes an age (for example 20) as input and prints something as "You look older than 20"
    }
}
