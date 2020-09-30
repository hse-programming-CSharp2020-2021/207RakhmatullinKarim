using System;

namespace Num_7
{
    class Program
    {
        static bool Sol(double a1, double b1, double c1)
        {
            if ((a1 == 0 && b1 == 0 && c1 == 0) || (a1 == 0 && b1 == 0 && c1 != 0) ||
                ((b1 * b1 - 4 * a1 * c1) < 0)) return false;
            else return true;

        }
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Input Coeffs");
            if(!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Error");
                return;
            }
            if (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Error");
                return;
            }
            if (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Error");
                return;
            }
            if (Sol(a, b, c))
            {
                double s1 = -b / (2 * a),
                    D = b * b - 4 * a * c,
                    s2 = Math.Sqrt(D) / (2 * a);
                if (D == 0)
                {
                    Console.WriteLine("X = {0:f3}", s1);
                }
                else
                {
                    Console.WriteLine("X1 = {0:f3}, X2 = {1:f3}", s1 + s2, s1 - s2);
                }
            }
            else Console.WriteLine("There're not any solutions");
        }
    }
}
