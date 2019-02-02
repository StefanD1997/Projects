using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            float n;
            Console.Write("Enter a number : ");
            n = Convert.ToSingle(Console.ReadLine());
            SphereVolumeCalculate(n);
        }

        //takes the radius of a sphere as input and calculate and display the surface and volume of the sphere
        static void SphereVolumeCalculate(float r)
        {
            double v, a;
            const float pi = 3.14159f;
            v = 4f / 3f * pi * Math.Pow(r, 3);
            a = 4 * pi * Math.Pow(r, 2);

            Console.WriteLine("Volume of Sphere is {0}", v);
            Console.WriteLine("Area of Sphere is {0}", a);
        }
    }
}
