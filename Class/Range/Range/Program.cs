using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("byte.MinVal = {0}  byte.MaxVal = {1}", 
                byte.MinValue, byte.MaxValue);
            Console.WriteLine("sbyte.MinVal = {0}  sbyte.MaxVal = {1}", 
                sbyte.MinValue, sbyte.MaxValue);

            Console.WriteLine("short.MinVal = {0}  short.MaxVal = {1}", 
                short.MinValue, short.MaxValue);
            Console.WriteLine("ushort.MinVal = {0}  ushort.MaxVal = {1}", 
                ushort.MinValue, ushort.MaxValue);

            Console.WriteLine("int.MinVal = {0}  int.MaxVal = {1}", 
                int.MinValue, int.MaxValue);
            Console.WriteLine("uint.MinVal = {0}  uint.MaxVal = {1}", 
                uint.MinValue, uint.MaxValue);

            Console.WriteLine("long.MinVal = {0}  long.MaxVal = {1}", 
                long.MinValue, long.MaxValue);
            Console.WriteLine("ulong.MinVal = {0}  ulong.MaxVal = {1}", 
                ulong.MinValue, ulong.MaxValue);

            // Integerizing the char values so we can see the
            // numeric range otherwise you just see blanks and a ?
            Console.WriteLine("char.MinVal = {0}  char.MaxVal = {1}", 
                (int)char.MinValue, (int)char.MaxValue);

            Console.WriteLine("float.MinVal = {0}  float.MaxVal = {1}", 
                float.MinValue, float.MaxValue);

            Console.WriteLine("double.MinVal = {0}  double.MaxVal = {1}",
                double.MinValue, double.MaxValue);

            Console.WriteLine("decimal.MinVal = {0}  decimal.MaxVal = {1}", 
                decimal.MinValue, decimal.MaxValue);

            Console.ReadLine();
        }
    }
}
