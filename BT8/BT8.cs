using System;

namespace Bt8
{
    class Program
    {
        static void Main(string[] args)
        {
            int chi_phi, doanh_thu, loi_nhua;
            Console.WriteLine("Nhap vao chi phi");
            chi_phi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao doanh thu");
            doanh_thu = Convert.ToInt32(Console.ReadLine());

            if (doanh_thu > chi_phi)
            {
                loi_nhua = doanh_thu - chi_phi;
                Console.WriteLine($"profit {loi_nhua}");
            }  
            else if (chi_phi > doanh_thu)
            {
                loi_nhua = chi_phi - doanh_thu;
                Console.WriteLine($"lose {loi_nhua}");
            }
            else
            {
                Console.WriteLine($"break even");
            }
        }
    }
}