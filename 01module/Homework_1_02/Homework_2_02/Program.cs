using System;

namespace Homework_2_02
{
    class Program
    {
        public static void Maxn(int n)
        {
            int x, y, z, a, b, c;
            x = n / 100;
            y = n % 10;
            z = n % 100 / 10;
            a = (x > y) ? (x > z) ? x : z : (z > y) ? z : y;
            c = (z < y) ? (z < x) ? z : x : (y < x) ? y : x;
            b = x + y + z - a - c;
            Console.WriteLine("{0}{1}{2}", a, b, c);

        }
        static void Main(string[] args)
        {
            int x;
            Console.Write("Input number ");
            if(!int.TryParse(Console.ReadLine(), out x) || (x < 100) || (x >= 1000))
            {
                Console.WriteLine("Error");
                return;
            }
            Maxn(x);

        }
    }
}
