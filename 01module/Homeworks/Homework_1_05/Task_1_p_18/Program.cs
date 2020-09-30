using System;

namespace Task_1_p_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Input the length of array");
            } while ((!int.TryParse(Console.ReadLine(), out n)) ||
            (n <= 0) || (n >= 32));
            Printer(GenerateArray(n));
        }

        static public void Printer(long[] arr)
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
            for (int i = 0; i < n; i++)
            {
                array[i] = (long)Math.Pow(2, i);
            }
            return array;
        }
    }
}
