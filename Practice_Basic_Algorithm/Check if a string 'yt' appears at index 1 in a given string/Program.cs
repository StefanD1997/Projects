using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_a_string__yt__appears_at_index_1_in_a_given_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckStringForYT("Iytf"));
            Console.WriteLine(CheckStringForYT("Hello"));
            Console.WriteLine(CheckStringForYT("Myty Friend"));

        }

        static string CheckStringForYT(string str)
        {
            if (str.Substring(1, 2).Equals("yt"))
            {
                return str.Remove(1, 2);
            }
            return str;
        }

        //Another Example
        public static string test(string str)
        {
            return str.Substring(1, 2).Equals("yt") ? str.Remove(1, 2) : str;
        }
    }
}
