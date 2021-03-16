using System;

namespace Num_7
{
    class Program
    {
        public static void NodAndNok(int a, int b, out int nod,
            out int nok)
        {
            int a1 = a,
                b1 = b;
            while (a != b) {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            nod = a;
            nok = a1 * b1 / nod;
        }
        static void Main(string[] args)
        {
            int a, b, nod, nok;
            while((!int.TryParse(Console.ReadLine(), out a)) ||
                (!int.TryParse(Console.ReadLine(), out b)) ||
                (a < 0) || (b < 0))
            {
                Console.WriteLine("Incorrect input");
            }
            NodAndNok(a, b, out nod, out nok);
            Console.WriteLine($"Nod = {nod} Nok = {nok}");
            
        }
    }
}
