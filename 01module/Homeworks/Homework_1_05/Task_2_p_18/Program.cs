using System;

namespace Task_2_p_18
{
    class Program
    {
        public static void Printer(long[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        public static long[] GenerateArray(int n)
        {
            long[] array = new long[n];
            int j = 1;
            for (int i = 0; i < n; i++)
            {
                array[i] = j;
                j += 2;
            }
            return array;
        }

        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Input the length of array");
            } while ((!int.TryParse(Console.ReadLine(), out n)) ||
            (n <= 0));
            Printer(GenerateArray(n));

        }
    }
}
