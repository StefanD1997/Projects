using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            char input;
            Console.Write("Enter : ");
            input = Convert.ToChar(Console.ReadLine());
            CheckInput(input);
        }

        //that takes a character as input and check the input (lowercase) is a vowel, a digit, or any other symbol
        static void CheckInput(char Input)
        {
            if ((Input == 'a') || (Input == 'e') || (Input == 'i') || (Input == 'o') || (Input == 'u'))
            {
                Console.WriteLine("Lowercase vowel");
            }
            else if (Input >= 0 || Input <= 9)
            {
                Console.WriteLine("A digit");
            }
            else
            {
                Console.WriteLine("Symbol");
            }
        }
    }
}
