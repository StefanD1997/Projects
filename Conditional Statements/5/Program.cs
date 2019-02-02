using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Enter your age : ");
            age = Convert.ToInt32(Console.ReadLine());
            CheckAge(age);
        }

        //read the age of a candidate and determine whether it is eligible for casting his/her own vote
        static void CheckAge(int age)
        {
            if (age >= 21)
            {
                Console.WriteLine("You are eligible to cast your vote");
            }
            else
            {
                Console.WriteLine("You are not eligible to cast your vote");
            }
        }
    }
}
