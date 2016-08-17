using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class DynamicArray
    {
        private int[] Array;
        
        public DynamicArray(int[] array)
        {
            Array = array;
        }
        public void Display()
        {
            foreach (int x in Array)
            {
                Console.Write("{0,2} ", x);
            }
            Console.WriteLine();
        }
        public void Insert(int index, int val)
        {
            int length = Array.Length;
            int[] temp = new int[length + 1];
            for (int i = 0; i < index; i++)
            {
                temp[i] = Array[i];
            }
            temp[index] = val;
            for (int j = index + 1; j < length + 1; j++)
            {
                temp[j] = Array[j - 1];
            }
            Array = temp;
        }
        
        public void RemoveAt(int index)
        {
            int length = Array.Length;
            int[] temp = new int[length - 1];
            for (int i = 0; i < index; i++)
            {
                temp[i] = Array[i];
            }
            for (int j = index + 1; j < length; j++)
            {
                temp[j - 1] = Array[j];
            }
            Array = temp;
        }
    }

    class Arrays_InsDel
    {

        static void Main()
        {
            int[] array = new int[6] { 10, 20, 30, 40, 50, -1 };

            DynamicArray da = new DynamicArray(array);
            da.Display();

            da.Insert(2, 22);
            da.Display();

            da.RemoveAt(3);
            da.Display();

            Console.Write("Press Enter...");
            Console.ReadLine();
        }
    }
}
