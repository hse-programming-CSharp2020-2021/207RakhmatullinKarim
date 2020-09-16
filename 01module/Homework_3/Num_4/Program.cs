using System;

namespace Num_4
{
    class Program
    {
        static bool Newton(double x, out double sq, out double eps)
        {
            double r1, r2 = x;
            sq = eps = 0.0;
            if(x <= 0)
            {
                Console.WriteLine("Error");
                return false;
            }
            do
            {
                r1 = r2;
                eps = x / r1 / 2 - r1 / 2;
                r2 = r1 + eps;
            } while (r1 != r2);
            sq = r1;
            return true;
        }
        static void Main(string[] args)
        {
            double x, res = 0, eps = 0;
            Console.WriteLine("Input a");
            if (!double.TryParse(Console.ReadLine(), out x)){
                Console.WriteLine("Error");
                return;
            }
            if(!Newton(x, out res, out eps))
            {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine($"root({x:f4}) = {res:f4}, eps = {eps:f4}");
        }
    }
}
