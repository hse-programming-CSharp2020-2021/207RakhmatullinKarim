using System;

namespace Task_2
{
    class Program
    {
        const int N = 10;
        static void Main(string[] args)
        {
            double[] X = FillArr(N);
            double[] Y = FillArr(N);
            double[] Xin, Xout, Yin, Yout;
            CreateArr(X, Y, out Xin, out Xout, out Yin, out Yout);
            Console.WriteLine("Coordinates");
            PrintArr(X);
            PrintArr(Y);
            Console.WriteLine("Dots in");
            PrintArr(Xin);
            PrintArr(Yin);
            Console.WriteLine("Dots out");
            PrintArr(Xout);
            PrintArr(Yout);
        }

        private static void PrintArr(double[] arrOfNumbers)
        {
            for(int i = 0; i < arrOfNumbers.Length; i++)
            {
                Console.Write($"{arrOfNumbers[i]:f3} \t");
            }
            Console.WriteLine();
        }

        private static void CreateArr(double[] X, double[] Y, out double[] Xin, out double[] Xout, out double[] Yin, out double[] Yout)
        {
            int jin = 0, jout = 0;
            int countOfIn = 0;
            for (int i = 0; i < N; i++)
            {
                if ((X[i] * X[i] + Y[i] * Y[i] >= 4) && (X[i] * X[i] + Y[i] * Y[i] <= 16))
                {
                    countOfIn++;
                }
            }
            Xin = new double[countOfIn];
            Xout = new double[N - countOfIn];
            Yin = new double[countOfIn];
            Yout = new double[N - countOfIn];
            for (int i = 0; i < N; i++)
            {
                if ((X[i] * X[i] + Y[i] * Y[i] >= 4) && (X[i] * X[i] + Y[i] * Y[i] <= 16))
                {
                    Xin[jin] = X[i];
                    Yin[jin] = Y[i];
                    jin++;
                }
                else
                {
                    Xout[jout] = X[i];
                    Yout[jout] = Y[i];
                    jout++;
                }
            }
            if(Xin.Length == 0)
            {
                Xin = null;
            }
            if (Yin.Length == 0)
            {
                Yin = null;
            }
            if (Xout.Length == 0)
            {
                Xout = null;
            }
            if (Yout.Length == 0)
            {
                Yout = null;
            }
        }

        private static double[] FillArr(int count)
        {
            Random rnd = new Random();
            double[] arrOfNumbers = new double[count];
            for (int i = 0; i < arrOfNumbers.Length; i++)
            {
                arrOfNumbers[i] = rnd.Next(-5, 5) + rnd.NextDouble();
            }

            return arrOfNumbers;
        }
    }
}
