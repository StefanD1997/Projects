using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_the_first_appearance_of_a_is_immediately_followed_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("Hahaha"));
        }

        public static bool test(string str)
        {
            var counter = 0;
            for (var i = 0; i < str.Length - 1; i++)
            {
                if (str[i].Equals('a')) counter++;
                if (str.Substring(i, 2).Equals("aa") && counter < 2)
                    return true;
            }
            return false;
        }
    }
}
