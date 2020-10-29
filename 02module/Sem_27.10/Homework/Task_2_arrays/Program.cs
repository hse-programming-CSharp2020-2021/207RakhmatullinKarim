using System;

namespace Task_2_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input length");
            int l;
            while ((!int.TryParse(Console.ReadLine(), out l)) || (l < 1))
            {
                Console.WriteLine("Incorrect input.");
            }
            int[][] matrix = new int[l][];
            for (int i = 0; i < l; i++)
            {
                matrix[i] = Shift(i, l);
            }
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        static public int[] Shift(int st, int l)
        {
            int[] line = new int[l];
            for(int i = 0; i < l; i++)
            {
                line[i] = i + 1;
            }
            for (int j = 0; j < st; j++)
            {
                int tmp = line[0];
                for (int i = 0; i < line.Length - 1; i++)
                {
                    line[i] = line[i + 1];
                }
                line[line.Length - 1] = tmp;
            }
            return line;
        }
    }
}
