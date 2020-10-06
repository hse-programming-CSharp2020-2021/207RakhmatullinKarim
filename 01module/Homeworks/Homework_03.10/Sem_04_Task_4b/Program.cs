using System;

namespace Sem_04_Task_4b
{
    class Program
    {
        const double MIN = -100, MAX = 100;
        const int N = 2;
        static void Main(string[] args)
        {
            double[,] matrix = GenerateMatrix(N);
            PrintMatrix(matrix);
            Console.WriteLine($"Det = {Det(matrix):f3}");

        }

        public static double Det(double[,] matrix)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        public static double[,] GenerateMatrix(int n)
        {
            double[,] matrix = new double[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = MIN + rnd.NextDouble() * (MAX - MIN);
                }
            }
            return matrix;
        }

        public static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
                {
                    Console.Write($"{matrix[i, j]:f3} \t");
                }
                Console.WriteLine();
            }
        }
    }


}
