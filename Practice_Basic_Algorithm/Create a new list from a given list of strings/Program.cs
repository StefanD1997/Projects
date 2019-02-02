using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_list_from_a_given_list_of_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mylist = CreateList(new List<string>(new string[] { "Abc", "cdef", "js", "php" }));
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
        }

        //create a new list from a given list of strings where strings will be in upper case in new string
        static List<string> CreateList(List<string> str)
        {
            return str.Select(x => x.ToUpper()).ToList();
        }
    }
}
