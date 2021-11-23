using System;

namespace BT7
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Nhap vao chu cai");
            ch = Convert.ToChar(Console.ReadLine().ToLower());

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("Nguyen am");
                    break;
                case 'i':
                    Console.WriteLine("Nguyen am");
                    break;
                case 'o':
                    Console.WriteLine("Nguyen am");
                    break;
                case 'u':
                    Console.WriteLine("Nguyen am");
                    break;
                case 'e':
                    Console.WriteLine("Nguyen am");
                    break;
                default:
                    Console.WriteLine("Phu am");
                    break;

            }
        }
    }
}