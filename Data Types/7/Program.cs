using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            float d, h, m, s;
            Console.Write("Enter distance : ");
            d = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter hour : ");
            h = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter minutes : ");
            m = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter seconds : ");
            s = Convert.ToSingle(Console.ReadLine());
            ConvertDistanceAndTime(d, h, m, s);
        }

        //that takes distance and time as input and displays the speed in kilometers per hour and miles per hour

        //timeSec = (hour*3600) + (min*60) + sec;
        //mps = distance/timeSec;
        //kph = (distance/1000.0f)/(timeSec/3600.0f);
        //mph = kph / 1.609f;
        static void ConvertDistanceAndTime(float distnace, float hour, float min, float sec)
        {
            float timeSec, mps, kph, mph;

            timeSec = (hour * 3600) + (min * 60) + sec;
            mps = distnace / timeSec;
            kph = (distnace / 1000.0f) / (timeSec / 3600.0f);
            mph = kph / 1.609f;

            Console.WriteLine("Speed in meters/sec is : {0}", mps);
            Console.WriteLine("Speed in km/h is : {0}", kph);
            Console.WriteLine("Speed in miles/h is : {0}", mph);
        }
    }
}
