using System;

namespace Hw_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            while ((!int.TryParse(Console.ReadLine(), out a)) ||
                (!int.TryParse(Console.ReadLine(), out b)) ||
                (!int.TryParse(Console.ReadLine(), out c)))
            {
                Console.WriteLine("Try again");
            }
            NewMethod(a, b, c);
        }

        private static void NewMethod(int a, int b, int c)
        {
            double x;
            for (x = 1; x < 1.2; x += 0.05)
            {
                Console.WriteLine($"{x:f3}" + '\t' +
                    $"{(a * x * x + b * x + c):f3}");
            }
            Console.WriteLine($"{x:f3}" + '\t' +
                $"{(a / x + Math.Sqrt(x * x + 1)):f3}");
            for (x = 1.25; x < 2.05; x += 0.05)
            {
                Console.WriteLine($"{x:f3}" + '\t' +
                    $"{((a + b * x) / Math.Sqrt(x * x + 1)):f3}");

            }
        }
    }
}
