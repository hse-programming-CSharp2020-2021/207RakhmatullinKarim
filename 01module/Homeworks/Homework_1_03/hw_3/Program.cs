using System;

namespace hw_3
{
    class Program
    {
        static bool G(double x1, double y1)
        {
            if ((x1 >= 0) && (y1 <= Math.Sqrt(2)) && ((1 / Math.Tan(x1 / y1) >= 1)
                || (1 / Math.Tan(x1 / y1) <= 0)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Input x and y");
            if((!double.TryParse(Console.ReadLine(), out x)) ||
                (!double.TryParse(Console.ReadLine(), out y)))
            {
                Console.WriteLine("Error");
                return;
            }
            if(G(x, y))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
