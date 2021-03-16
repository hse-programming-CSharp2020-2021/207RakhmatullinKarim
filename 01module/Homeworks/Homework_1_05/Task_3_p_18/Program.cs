using System;

namespace Task_3_p_18
{
    class Program
    {
        public static void Printer(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        public static int[] GenerateArray(int n, int a, int d)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = a + d * i;
            }
            return arr;

        }

        static void Main(string[] args)
        {
            int a, n, d;
            Console.WriteLine("Input the first member, quantity of members " +
                "and the difference");
            while ((!int.TryParse(Console.ReadLine(), out a)) ||
                (!int.TryParse(Console.ReadLine(), out n)) ||
                (!int.TryParse(Console.ReadLine(), out d)) ||
                (n < 1))
            {
                Console.WriteLine("Incorrect input. Try again.");
            }
            Printer(GenerateArray(n, a, d));
        }
    }
}
