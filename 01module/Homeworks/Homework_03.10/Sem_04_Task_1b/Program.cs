﻿using System;

namespace Sem_04_Task_1b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Validate();
            int[,] matrix = GenerateMatrix(n);
            PrintMatrix(n, matrix);
        }

        public static void PrintMatrix(int n, int[,] matrix)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " \t");
                }
                Console.WriteLine();
            }
        }

        public static int[,] GenerateMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == n - j - 1)
                    {
                        matrix[i, j] = 0;
                    }
                    else if (n - j - 1 > i)
                    {
                        matrix[i, j] = -1;
                    }
                    else
                    {
                        matrix[i, j] = 1;
                    }
                }
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
    }
}
