using System;

namespace BT5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            
            Console.WriteLine("Nhap vao canh a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao canh b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao canh c");
            c = Convert.ToInt32(Console.ReadLine());
            
            var sum = a + b + c;

            if (sum == 180)
            {
                Console.WriteLine("La 3 goc cua tam giac");
            }
            else
            {
                Console.WriteLine("Khong phai 3 canh cua tam giac");
            }
        }
    }
}