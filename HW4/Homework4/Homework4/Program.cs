using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int x = int.Parse(Console.ReadLine());
            int[] factorials = new int[x];
            int j = 1;
            for (int i = 0; i < x; i++)
            {
                if (i == 0)
                {
                    factorials[i] = j;
                    Console.WriteLine(j + "! = " + factorials[i]);
                    j++;
                    continue;
                }
                factorials[i] = j * factorials[i - 1];
                Console.WriteLine(j + "! = " + factorials[i]);
                j++;
            }
            Console.ReadLine();
        }
    }
}
