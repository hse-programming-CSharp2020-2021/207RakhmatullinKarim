using System;

namespace Sem_04_Task_6
{
    class Program
    {
        const int MAX = 20, MIN = 0, STRINGS = 3, COLUMNS = 6;
        static void Main(string[] args)
        {
            int[,] matrix = GenerateMatrix();
            PrintMatrix(matrix);
            Console.WriteLine();
            int[] dets = { Det(matrix, 0), Det(matrix, 3) };
            for(int i = 0; i < dets.Length; i++)
            {
                Console.Write($"Det {i + 1} = {dets[i]} ");
            }
        }

        public static int[,] GenerateMatrix()
        {
            int[,] matrix = new int[STRINGS, COLUMNS];
            Random rnd = new Random();
            for (int i = 0; i < STRINGS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    matrix[i, j] = rnd.Next(MIN, MAX + 1);
                }
            }
            return matrix;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < STRINGS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    Console.Write($"{matrix[i, j]}" + "\t");
                }
                Console.WriteLine();
            }
        }

        public static int Det(int[,] matrix, int j)
        {
            int a = matrix[0, j],
                b = matrix[0, j + 1],
                c = matrix[0, j + 2],
                d = matrix[1, j],
                e = matrix[1, j + 1],
                f = matrix[1, j + 2],
                g = matrix[2, j],
                h = matrix[2, j + 1],
                i = matrix[2, j + 2];
            return a * e * i + b * f * g + c * d * h - a * f * h -
                b * d * i - c * e * g;
        }

        
    }
}
