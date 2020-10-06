using System;

namespace Sem_04_Task_5c
{
    class Program
    {
        const double MAX = 25, MIN = 0;
        static void Main(string[] args)
        {
            int n = ValidateInt();
            double[,] matrix = GenerateMatrix(n);
            PrintMatrix(matrix);
            Console.WriteLine();
            PrintPart(matrix);
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

        public static void PrintPart(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (((i > j) && (i > matrix.GetLength(0) - j - 1)) ||
                        ((i < j) && (i < matrix.GetLength(0) - j - 1)))
                    {
                        Console.Write($"{matrix[i, j]:f3}" + "\t\t");
                    }
                    else { Console.Write("\t\t"); }
                }
                Console.WriteLine();
            }
        }

        public static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
                {
                    Console.Write($"{matrix[i, j]:f3}" + "\t\t");
                }
                Console.WriteLine();
            }
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
    }
}
