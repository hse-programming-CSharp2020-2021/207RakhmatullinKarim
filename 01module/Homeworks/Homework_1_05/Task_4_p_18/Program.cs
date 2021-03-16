using System;

namespace Task_4_p_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Input quantity of members");
            } while ((!int.TryParse(Console.ReadLine(), out n)) || (n <= 1));
            ReversePrinter(GenerateFibArr(n));
        }

        public static int[] GenerateFibArr(int n)
        {
            int[] FibArr = new int[n];
            FibArr[0] = 1;
            FibArr[1] = 1;
            for (int i = 2; i < n; i++)
            {
                FibArr[i] = FibArr[i - 1] + FibArr[i - 2];
            }
            return FibArr;
        }

        public static void ReversePrinter(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
