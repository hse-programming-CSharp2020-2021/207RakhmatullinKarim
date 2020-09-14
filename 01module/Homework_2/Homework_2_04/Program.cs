using System;

namespace Homework_2_04
{
    class Program
    {
        public static void My(int n)
        {
            int a, b, c, d;
            a = n / 1000;
            b = n % 1000 / 100;
            c = n % 100 / 10;
            d = n % 10;
            Console.WriteLine($"{d} {c} {b} {a}");

        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Input number ");
            if (!int.TryParse(Console.ReadLine(), out number) ||
                number < 1000 || number >= 10000)
            {
                Console.WriteLine("Error");
                return;
            }

            My(number);

        }
    }
}
