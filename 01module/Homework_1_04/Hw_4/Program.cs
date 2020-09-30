using System;

namespace Hw_4
{
    class Program
    {
        public static long PowOfTwo(int pow)
        {
            return 2 << pow - 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input two powers of 2");
            int n, m;
            Validate(out n, out m);
            CountSum(n, m);
        }

        public static void CountSum(int n, int m)
        {
            long a1, a2;
            if (n == 0)
            {
                a1 = 1;
            }
            else
            {
                a1 = PowOfTwo(n);
            }
            if (m == 0)
            {
                a2 = 1;
            }
            else
            {
                a2 = PowOfTwo(m);
            }
            long sum = a1 + a2;
            Console.WriteLine(sum);
        }

        public static void Validate(out int n, out int m)
        {
            while ((!int.TryParse(Console.ReadLine(), out n)) ||
                (!int.TryParse(Console.ReadLine(), out m)) || (n < 0) ||
                (m < 0) || (m + n >= 32))
            {
                Console.WriteLine("Try again.");
            }
        }
    }
}
