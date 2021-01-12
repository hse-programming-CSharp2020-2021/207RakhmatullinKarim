using System;

namespace Task_2
{
    class Program
    {
        delegate int Cast(double n);
        static void Main(string[] args)
        {
            Cast Anonim1 = delegate (double param)
            {
                return (int)param;
            };
            Cast Anonim2 = delegate (double param)
            {
                return param.ToString().Length;
            };
            double[] tests = { 78.8, 23.4, 3.21, 4.9, 3 };
            for(int i = 0; i < tests.Length; i++)
            {
                Console.WriteLine(Anonim1(tests[i]));
                Console.WriteLine(Anonim2(tests[i]));
            }
            Cast cast3 = p => (int)p;
            Cast obj3 = (par) =>
            {
                Console.WriteLine("Del");
                return (int)Math.Ceiling(par);
            };
        }
    }
}
