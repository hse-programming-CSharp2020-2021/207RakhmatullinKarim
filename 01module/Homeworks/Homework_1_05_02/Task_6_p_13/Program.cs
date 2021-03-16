using System;

namespace Task_6_p_13
{
    class Program
    {
        public static void Print(int[] arr)
        {
            foreach (double a in arr)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine();
        }

        public static int[] DeleteElement(ref int[] arr, int indexToDelete)
        {
            for (int i = indexToDelete; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
            return arr;
        }

        public static int[] GenerateArray(int n)
        {
            int[] arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-10, 11);
            }

            return arr;
        }

        public static int Validate()
        {
            int n;
            Console.WriteLine("Input the amount of elements.");
            while ((!int.TryParse(Console.ReadLine(), out n)) || (n <= 0))
            {
                Console.WriteLine("Error. Try again.");
            }

            return n;
        }

        public static int[] Compress(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (Math.Abs(arr[i] + arr[i + 1]) % 3 == 0)
                {
                    arr[i] *= arr[i + 1];
                    DeleteElement(ref arr, i + 1);

                }
            }

            return arr;
        }

        static void Main(string[] args)
        {
            int n;
            n = Validate();
            int[] arr = GenerateArray(n);
            Print(arr);
            int[] compressedArr = Compress(arr);
            Print(compressedArr);
        }

    }
}
