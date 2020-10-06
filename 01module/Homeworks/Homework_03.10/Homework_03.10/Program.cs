using System;

namespace Homework_03._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Validate();
            int[] arr = new int[n];
            GenerateArray(ref arr);
            Console.Write("Generated array: \t");
            Print(arr);
            ArrayHill(ref arr);
            Console.Write("Sorted array: \t\t");
            Print(arr);
        }

        public static void ArrayHill(ref int[] arr)
        {
            Array.Sort(arr);
            for (int i = 1; i <= arr.Length / 2; i++)
            {
                Array.Reverse(arr, i, arr.Length - 2 * i + 1);
                Array.Reverse(arr, i, arr.Length - 2 * i);
            }
        }

        public static void Print(int[] arr)
        {
            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }

        public static int Validate()
        {
            int n;
            Console.WriteLine("Input the length of array");
            while ((!int.TryParse(Console.ReadLine(), out n)) || (n <= 0))
            {
                Console.WriteLine("Error. Try again.");
            }

            return n;
        }

        public static void GenerateArray(ref int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10, 11);
            }
        }
    }
}
