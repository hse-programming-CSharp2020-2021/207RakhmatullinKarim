using System;

namespace hw_2
{
    class Program
    {
        static void reverse(uint n)
        {
            uint p = 1;
            string res = "";
            if (n % 10 == 0)
            {
                while (n % (p * 10) == 0) p *= 10;
                n /= p;
            }
            while (n > 0)
            {
                res += (n % 10);
                n /= 10;

            }
            Console.WriteLine(res);
        }
        static void Main(string[] args)
        {
            uint x;
            Console.WriteLine("Input number");
            if (!uint.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Error");
                return;
            }
            reverse(x);
        }
    }
}
