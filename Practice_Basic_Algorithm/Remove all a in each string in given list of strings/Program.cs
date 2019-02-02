using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_all_a_in_each_string_in_given_list_of_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mylist = CreateList(new List<string>(new string[] { "abc", "cdaef", "js", "php" }));
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
        }

        //remove all "a" in each string in given list of strings and return the new string
        static List<string> CreateList(List<string> str)
        {
            var s = str.Select(x => x.Replace("a", "").Trim());
            return s.ToList();
        }
    }
}
