﻿using System;

namespace BT12
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            double s = 0.0;

            Console.Write("Nhap so phan tu: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");
            for (i = 1; i <= n; i++)
            {
                if (i < n)
                {
                    Console.Write("1/{0} + ", i);
                }
                else
                {
                    Console.Write("1/{0}", i);
                }

                s += 1 / (float)i;
            }
            Console.Write("\n\nTong cua day {0} phan tu bang: {1} \n", n, s);

            Console.ReadKey();
        }
    }
}