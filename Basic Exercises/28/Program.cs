using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Display the pattern like pyramid using the alphabet.";
            ReverseString(line);
        }

        //reverse the words of a sentence.
        static string ReverseString(string str)
        {
            string result = "";
            List<string> wordsList = new List<string>();
            string[] words = str.Split(new[] { " " }, StringSplitOptions.None);

            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
            }
            wordsList.Add(result);
            foreach (string s in wordsList)
            {
                Console.WriteLine(s);
            }
            return result;
        }
    }
}
