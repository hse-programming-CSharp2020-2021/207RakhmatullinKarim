using System;

namespace hw_p14_4
{
    class Program
    {
        static int My(int x, int y, int z)
        {
            int t;
            if(x % 100 > y % 100)
            {
                if(x % 100 > y % 100)
                {
                    t = x;
                    x = z;
                    z = x;
                }
                else
                {
                    t = x;
                    x = y;
                    y = t;
                }
            }
            else if(y % 100 > z % 100)
            {
                t = y;
                y = z;
                z = t;
            }
            return x;

        }
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Input 3 numbers");
            if (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Error");
                return;
            }
            if (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Error");
                return;
            }
            if (!int.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine($"Min number is {My(a, b, c)}");


        }
    }
}
