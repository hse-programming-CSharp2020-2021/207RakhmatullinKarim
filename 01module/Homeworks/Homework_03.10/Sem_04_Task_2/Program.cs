using System;

namespace Sem_04_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Validate();
            int k = CountStrings(n);
            int[][] arr = LadderArr(n, k);
            PrintArr(arr);
        }

        public static void PrintArr(int[][] arr)
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

        public static int[][] LadderArr(int n, int k)
        {
            int[][] arr = new int[k][];
            for (int i = 0; i < k - 1; i++)
            {
                arr[i] = new int[i + 1];
                for (int j = 0; j < i + 1; j++)
                {
                    arr[i][j] = n--;
                }
            }
            arr[k - 1] = new int[n];
            for (int i = 0; i < arr[k - 1].Length; i++)
            {
                arr[k - 1][i] = n--;
            }

            return arr;
        }

        public static int CountStrings(int n)
        {
            int tmp = n, k = 0;
            while (tmp > 0)
            {
                k++;
                tmp -= k;
            }

            return k;
        }

        public static int Validate()
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
