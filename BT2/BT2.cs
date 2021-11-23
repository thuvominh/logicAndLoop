using System;

namespace BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("x = y^2 - 2y +1");
            Console.WriteLine();

            for (y = -5; y <= 5; y++)
            {
                x = y * y - 2 * y + 1;
                Console.WriteLine($"gia tri y = {y}, gia tri x = {x}");
            }
        }
    }
}