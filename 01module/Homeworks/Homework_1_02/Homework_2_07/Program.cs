using System;

namespace Homework_2_07
{
    class Program
    {
        static public void f1(double x)
        {
            Console.WriteLine($"fraq {(x - (int)x):f3} int {(int)x}");

        }
        static public void f2(double x)
        {
            if (x < 0)
            {
                Console.WriteLine("Error Square = {x * x:f3}");
            }
            else
            {
                Console.WriteLine($"Sqr = {Math.Sqrt(x):f3} Square = {x * x:f3}");
            }
        }
        static void Main(string[] args)
        {
            double n;
            Console.WriteLine("Input ");
            if(!double.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Error");
                return;
            }
            f1(n);
            f2(n);


        }
    }
}