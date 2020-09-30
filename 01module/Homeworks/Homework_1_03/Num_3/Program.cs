using System;

namespace Num_3
{
    class Program
    {
        static public double Square(double x)
        {
            return x * x;
        }
        static public void Integ(double A1, double d1)
        {
            double x = 0, s = 0;
            while (x + d1 < A1)
            {
                s = s + (Square(x) + Square(x + d1)) * d1 / 2;
                x = x + d1;
            }
            s = s + (Square(x) + Square(A1)) * (A1 - x) / 2;
            Console.WriteLine("{0:f3}", s);
        }


            static void Main(string[] args)
        {
            double A, d;
            Console.WriteLine("Input A");
            if(!double.TryParse(Console.ReadLine(), out A) || (A != 0))
            {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine("Input d");
            if(!double.TryParse(Console.ReadLine(), out d) || (d <= 0))
            {
                Console.WriteLine("Error");
                return;
            }
            Integ(A, d);


        }
    }
}
