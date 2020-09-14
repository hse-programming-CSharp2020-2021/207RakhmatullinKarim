using System;

namespace Num_6
{
    class Program
    {
        static double Total(double k, double r, uint n)
        {
            for (int i = 0; i < n; i++)
            {
                k += k * 0.01 * r;
            }
            return k;
        }
        static void Main(string[] args)
        {
            double s, p;
            uint y;
            Console.WriteLine("Input sum, percent and years");
            if(!double.TryParse(Console.ReadLine(), out s) || s <= 0)
            {
                Console.WriteLine("Error");
                return;
            }
            if (!double.TryParse(Console.ReadLine(), out p) || p <= 0)
            {
                Console.WriteLine("Error");
                return;
            }
            if (!uint.TryParse(Console.ReadLine(), out y) || y <= 0)
            {
                Console.WriteLine("Error");
                return;
            }
            for (uint i = 0; i < y; i++)
            {
                Console.WriteLine("{0} \t {1:f3}", i + 1, Total(s, p, i)) ;
            }


        }
    }
}
