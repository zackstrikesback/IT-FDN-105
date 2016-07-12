using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConversions
{
    class Test
    {
        static void Main()
        {
            string strVal;
            int intVal;
            double dblVal;

            // strVal must "look" like an integer
            // if it doesn't the Parse() function will fail.
            strVal = "45";

            // try to "Parse" the string into an integer
            intVal = int.Parse(strVal);

            strVal = "45.2";
            dblVal = double.Parse(strVal);

            // Converting ANY type to a string is trival
            // because EVERY object supports ToString()
            strVal = intVal.ToString();
        }
    }
}
