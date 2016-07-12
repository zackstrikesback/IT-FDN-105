using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many seconds?");
            int sec = int.Parse(Console.ReadLine());
            int min = 60;
            int hrs = 3600;
            int day = 86400;
            if (sec < min)
            {
                Console.WriteLine(sec + " seconds");
                Console.ReadLine();
            }
            else if (sec < hrs)
            {
                Console.WriteLine(sec / min + " minutes " + sec % min + " seconds");
                Console.ReadLine();
            }
            else if (sec < day)
            {
                int x = sec % hrs;
                Console.WriteLine(sec / hrs + " hours " + x / min + " minutes " + x % min + " seconds");
                Console.ReadLine();
            }
            else
            {
                int x = sec % day;
                int y = x % hrs;
                Console.WriteLine(sec / day + " days " + x / hrs + " hours " + y / min + " minutes " + y % min + " seconds");
                Console.ReadLine();
            }
        }
    }
}