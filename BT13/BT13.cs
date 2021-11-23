using System;

namespace BT13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, t = 9;
            int sum = 0;

            

            Console.Write("Nhap so phan tu: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                sum += t;
                if (i < n)
                {
                    Console.Write("{0} + ", t);
                }
                else
                {
                    Console.Write("{0}", t);
                }

                sum = sum + t;
                t = t * 10 + 9;
            }
            Console.Write("\nTong cua day so tren = {0} \n", sum);

            Console.ReadKey();
        
        }
    }
}