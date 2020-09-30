using System;

namespace Homework_2_03
{
    class Program
    {
        public static void Sol(double a, double b, double c)
        {
            double t, s;
            t = -b / (2 * a);
            s = Math.Sqrt(b * b - 4 * a * c) / (2 * a);
            if ((b * b - 4 * a * c) >= 0)
            {
                Console.WriteLine($"X1 = {(t + s):f3} X2 = {(t - s):f3}");
            }
            else Console.WriteLine("Complex solutions");

        }
        static void Main(string[] args)
        {
            double x, y, z;
            Console.Write("Enter coeffs ");
            if(!(double.TryParse(Console.ReadLine(), out x)))
            {
                Console.WriteLine("Error");
                return;
            }
            if (!(double.TryParse(Console.ReadLine(), out y)))
            {
                Console.WriteLine("Error");
                return;
            }
            if (!(double.TryParse(Console.ReadLine(), out z)))
            {
                Console.WriteLine("Error");
                return;
            }
            Sol(x, y, z);




        }
    }
}
