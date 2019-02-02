using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int height;
            Console.Write("Enter you height in centimeters : ");
            height = Convert.ToInt32(Console.ReadLine());
            Height(height);
        }

        //accept the height of a person in centimeter and categorize the person according to their height
        static void Height(int height)
        {
            if (height <= 140)
            {
                Console.WriteLine("This person is short");
            }
            else if (height <= 170)
            {
                Console.WriteLine("This person is medium");
            }
            else
            {
                Console.WriteLine("This person in tall");
            }
        }
    }
}
