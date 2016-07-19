using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, -2, 100, 12, 4, -5 };
            int[] sorted = numbers; 
            int max = numbers[0];
            int min = numbers[0];
            Console.WriteLine("Enter # to check if it's in array: ");
            int x = int.Parse(Console.ReadLine());
            bool y = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 1; j < sorted.Length; j++)
                {
                    if (sorted[j] < sorted[j - 1])
                    {
                        int n = sorted[j - 1];
                        sorted[j - 1] = sorted[j];
                        sorted[j] = n;
                    }
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    continue;
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    continue;
                }
            }
            for (int k = 0; k < numbers.Length; k++)
            {
                if (x == numbers[k])
                {
                    y = true;
                }
            }
            if (y)
            {
                Console.WriteLine(x + " is in array.");
            } 
            else
            {
                Console.WriteLine(x + " is not in array.");
            }
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Min = " + min);
            Console.WriteLine("Sorted array: [{0}]", string.Join(", ", sorted));
            Console.ReadLine();
        }
    }
}
