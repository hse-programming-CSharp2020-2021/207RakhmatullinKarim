using System;

namespace Task_3_p_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            x = ValidateAngle();
            PrintSin(x);
            Console.WriteLine($"Math.Sin(x) = {Math.Sin(x)}");
            int n = ValidateN();
            double[] result = ArrSinFrom1(n);
            Print(result);
        }

        public static void PrintSin(double x)
        {
            double sin, sinOld, memb;
            int n;
            for (n = 1, sin = memb = x, sinOld = 0; sin != sinOld; n++)
            {
                Console.WriteLine($"sin({x}) = {sin} \tmemb = {memb}");
                sinOld = sin;
                memb *= -x * x / 2 / n / (2 * n + 1);
                sin += memb;
            }
        }

        public static void Print(double[] arr)
        {
            Console.Write("sin(1) = ");
            foreach (double a in arr)
            {
                Console.Write($"{a:f3} ");
            }
        }

        public static int ValidateN()
        {
            int n;
            Console.WriteLine("Input the amount of members.");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Incorrect input. Try again.");
            }
            return n;
        }
        public static double[] ArrSinFrom1(int n)
        {
            double[] arrSin = new double[n];
            double x = 1;
            arrSin[0] = x;
            int j = 3;
            int fact = 1;
            double sin = x;
            for (int i = 1; i < n; i++)
            {
                sin += (Math.Pow(-1, i) * Math.Pow(x, j)) / (fact * (j - 2) *
                    (j - 1));
                arrSin[i] = sin;
                j += 2;
            }

            return arrSin;
        }

        public static double ValidateAngle()
        {
            double angle,
                   x;
            Console.WriteLine("Input the angle.");
            while(!double.TryParse(Console.ReadLine(), out angle))
            {
                Console.WriteLine("Incorrect input. Try again.");
            }
            x = angle % (2 * Math.PI);
            return x;
        }
    }
}
