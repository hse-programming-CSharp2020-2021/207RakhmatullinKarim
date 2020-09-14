using System;

namespace hw_p14_2
{
    class Program
    {
        static double G(double x1, double y1)
        {
            if ((x1 < y1) && (x1 > 0))
            {
                return x1 + Math.Sin(y1);

            }
            else if ((x1 > y1) && (x1 < 0))
            {
                return y1 - Math.Cos(x1);
            }
            else  return 0.5 * x1 * y1; 
        }
        static void Main(string[] args)
        {
            double x, y;
            if(!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Error");
                return;
            }
            if(!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine($"Answer {G(x, y):f3}");

        }
    }
}
