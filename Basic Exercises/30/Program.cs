using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertHexadecimal("4B0"); 
        }

        //convert a hexadecimal number to decimal number
        static void ConvertHexadecimal(string x)
        {
            int decValue = int.Parse(x, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("From Hexdecimal to Decimal {0} = {1}", x, decValue);
        }
    }
}
