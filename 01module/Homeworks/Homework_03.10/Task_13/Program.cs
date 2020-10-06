using System;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            Console.WriteLine("Input the length of array");
            n = Validate();
            Console.WriteLine("Input k");
            k = Validate();
            int[] arr = GenArr(n);
            Print(arr);
            PrintKArr(arr, k);
        }

        public static int[] GenArr(int n)
        {
            int[] arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(1, 101);
            }

            return arr;
        }

        public static void PrintKArr(int[] arr, int k)
        {
            for(int i = k; i < arr.Length; i += k)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
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
            while ((!int.TryParse(Console.ReadLine(), out n)) || (n < 1))
            {
                Console.WriteLine("Error. Try again.");
            }

            return n;
        }
    }
}
