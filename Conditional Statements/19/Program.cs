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
            string grade;
            Console.Write("Enter Grade : ");
            grade = Console.ReadLine().ToUpper();
            Grades(grade);
        }

        //accept a grade and declare the equivalent description
        static void Grades(string n)
        {
            if (n.Equals("E"))
            {
                Console.WriteLine("Excellent");
            }
            else if (n.Equals("V"))
            {
                Console.WriteLine("Very Good");
            }
            else if (n.Equals("G"))
            {
                Console.WriteLine("Good");
            }
            else if (n.Equals("A"))
            {
                Console.WriteLine("Avarege");
            }
            else if (n.Equals("F"))
            {
                Console.WriteLine("Failed");
            }
            else
            {
                Console.WriteLine("Please enter a valid grade");
            }
        }
    }
}
