using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            char x, y, z;
            Console.Write("Enter a letter : ");
            x = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter a letter : ");
            y = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter a letter : ");
            z = Convert.ToChar(Console.ReadLine());
            char[] chars = new char[3];
            chars[0] = x;
            chars[1] = y;
            chars[2] = z;
            Console.WriteLine();
            Console.WriteLine(ReverseString(chars));
        }

        //program that takes three letters as input and display them in reverse order
        static string ReverseString(char[] array)
        {
            Array.Reverse(array);
            foreach (char item in array)
            {
                Console.WriteLine(item);
            }
            return array.ToString();
        }

    }
}
