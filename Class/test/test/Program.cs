﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Test
{
    static void Main()
    {
        int[] xlist = new int[] { 7, -2, -5 };

        for (int x = 0; x < xlist.Length - 1; x++)
        {
            if (xlist[x] > xlist[x + 1])
            {
                int t = xlist[x];
                xlist[x] = xlist[x + 1];
                xlist[x + 1] = t;
            }
        }

        foreach (int v in xlist)
        {
            Console.Write("{0} ", v);
        }
        Console.ReadLine();
    }
}
