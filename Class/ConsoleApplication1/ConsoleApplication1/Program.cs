using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Month?");
            string month = Console.ReadLine();
            int m = int.Parse(month);
            if (m < 8)
            {
                if (m % 2 != 0)
                {
                    Console.WriteLine("31 days");
                    Console.ReadLine();
                }
                else if (m == 2)
                {
                    Console.WriteLine("28 days");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("30 days");
                    Console.ReadLine();
                }
            }
            else
            {
                if (m % 2 != 0)
                {
                    Console.WriteLine("30 days");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("31 days");
                    Console.ReadLine();
                }
            }
        }
    }
}
