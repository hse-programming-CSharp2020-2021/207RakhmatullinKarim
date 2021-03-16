using System;

namespace hw_p14_3
{
    class Program
    {
        static double G(double x1)
        {
            if (x1 <= 0.5) return Math.Sin(Math.PI / 2);
            else return Math.Sin((Math.PI * (x1 - 1)) / 2);
        }
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Input ");
            if(!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine($"G(x) = {G(x):f3}");
        }
    }
}
