using System;

namespace hw_1
{
    class Program
    {
        static bool isGood(int x)
        {
            if ((x / 100 == x % 10) && (x / 100 == x % 100 / 10)) return true;
            else return false;
        }
        static void find()
        {
            int t = 1, s = 1;
            while (s < 100 || !isGood(s))
            {
                t++;
                s += t;

            }
            Console.WriteLine($"1 + 2 + 3 + ... + {t - 2} + {t - 1} + {t} = {s}");
            Console.WriteLine($"{t} elements");

        }
        static void Main(string[] args)
        {
            find();

        }
    }
}
