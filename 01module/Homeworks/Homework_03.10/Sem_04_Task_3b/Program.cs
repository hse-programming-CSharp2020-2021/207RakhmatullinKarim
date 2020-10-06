using System;

namespace Sem_04_Task_3b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Validate();
            char[][] stars = FillStars(n);
            PrintArr(stars);
        }

        public static char[][] FillStars(int n)
        {
            char[][] stars = new char[n][];
            for (int i = 0; i < n; i++)
            {
                stars[i] = new char[n / 2 + i];
            }
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = n / 2 - i - 1; j < n / 2 + i; j++)
                {
                    stars[i][j] = '*';
                }
            }
            for (int i = n / 2; i < n; i++)
            {
                for (int j = 0; j < stars[i].Length; j++)
                {
                    stars[i][j] = '*';
                }
            }
            return stars;
        }

        public static int Validate()
        {
            int n;
            Console.WriteLine("Input n");
            while ((!int.TryParse(Console.ReadLine(), out n)) || (n <= 0) ||
                (n % 2 == 0))
            {
                Console.WriteLine("Error. Try again");
            }

            return n;
        }

        public static void PrintArr(char[][] arr)
        {
            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " \t");
                }
                Console.WriteLine();
            }
        }
    }
}
