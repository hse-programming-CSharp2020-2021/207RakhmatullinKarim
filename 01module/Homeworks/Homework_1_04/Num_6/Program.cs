using System;

namespace Num_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            while(!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Try again");
            }
            int powOf1 = 1,
                powOf2 = 3,
                powOfx = 4,
                fact = 24;

            double r1 = 1,
                r2 = 0;
            while(r1 - r2 != 0.000)
            {
                r2 = r1;
                r1 += (Math.Pow(-1, powOf1) * Math.Pow(2, powOf2) *
                    Math.Pow(x, powOfx) / (double)fact);
                powOfx += 2;
                powOf2 += 2;
                powOf1 += 1;
                fact = fact * (fact + 1) * (fact + 2);
                Console.WriteLine(fact);

            }
            
            Console.WriteLine(r1);
        }
    }
}
