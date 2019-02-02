using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29
{
    class Program
    {
        static void Main(string[] args)
        {
            SizeOfFile();
        }

        //find the size of a specified file in bytes
        static void SizeOfFile()
        {
            FileInfo f = new FileInfo("C:/Users/Stefan/Desktop/Ethical/Networks-Pre-Connection-Attacks1.pdf");
            Console.WriteLine("Size of file:" + f.Length.ToString());
        }
    }
}
