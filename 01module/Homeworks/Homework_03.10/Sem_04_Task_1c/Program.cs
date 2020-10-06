using System;

namespace Sem_04_Task_1c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Validate();
            int[,] matrix = CreateMatrix(n);
            PrintMatrix(matrix);
        }

        public static int[,] CreateMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            int k = 1,
                left = 0,
                length = matrix.GetUpperBound(0) + 1,
                right = length - 1,
                up = 1,
                down = length - 1,
                param1 = 0,
                param2 = length - 1;
            while (k <= matrix.Length)
            {
                int j1 = left;
                while ((j1 <= right) && (k <= matrix.Length))
                {
                    matrix[param1, j1] = k++;
                    j1++;
                }
                right--;
                int i1 = up;
                while ((i1 <= down) && (k <= matrix.Length))
                {
                    matrix[i1, param2] = k++;
                    i1++;
                }
                down--;
                int j2 = right;
                while ((j2 >= left) && (k <= matrix.Length))
                {
                    matrix[param2, j2] = k++;
                    j2--;
                }
                left++;
                int i2 = down;
                while ((i2 >= up) && (k <= matrix.Length))
                {
                    matrix[i2, param1] = k++;
                    i2--;
                }
                param1++;
                param2--;
                up++;

            }

            return matrix;
        }

        public static int Validate()
        {
            int n;
            Console.WriteLine("Input length of matrix");
            while ((!int.TryParse(Console.ReadLine(), out n)) || (n <= 0))
            {
                Console.WriteLine("Error. Try again");
            }

            return n;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(0) + 1; j++)
                {
                    Console.Write(matrix[i, j] + " \t");
                }
                Console.WriteLine();
            }
        }
    }
}
