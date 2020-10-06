using System;

namespace Sem_04_Task_4a
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = ValidateInt();
            double min,
                max;
            do
            {
                Console.WriteLine("Input minimum");
                min = ValidateDouble();
                Console.WriteLine("Input maximum"); ;
                max = ValidateDouble();
            } while (min >= max);

            double[,] matrix = GenerateMatrix(n, min, max);
            PrintMatrix(matrix);
        }

        public static double[,] GenerateMatrix(int n, double min, double max)
        {
            double[,] matrix = new double[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = min + rnd.NextDouble() * (max - min);
                }
            }
            return matrix;
        }

        public static double ValidateDouble()
        {
            double n;
            while (!double.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Error. Try again");
            }

            return n;
        }

        public static int ValidateInt()
        {
            int n;
            Console.WriteLine("Input n");
            while ((!int.TryParse(Console.ReadLine(), out n)) || (n <= 0))
            {
                Console.WriteLine("Error. Try again");
            }

            return n;
        }

        public static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
                {
                    Console.Write($"{matrix[i, j]:f3} " + '\t');
                }
                Console.WriteLine();
            }
        }
    }
}
