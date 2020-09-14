using System;

namespace Homework_2
{
    class Program
    {
        public static int f(int x)
        {
            int tmp;
            tmp = x * x;
            return 12 * tmp * tmp + 9 * tmp * x - 3 * tmp + 2 * x - 4;

        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Input x");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine($"f(x) = {f(n)}");
            

        }
    }
}
