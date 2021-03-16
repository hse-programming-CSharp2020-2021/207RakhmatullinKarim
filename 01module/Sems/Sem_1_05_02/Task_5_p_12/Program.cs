using System;

namespace Task_5_p_12
{
    class Program
    {
        public static int Validate()
        {
            int n;
            while ((!int.TryParse(Console.ReadLine(), out n)) || (n <= 0))
            {
                Console.WriteLine("Error. Try again.");
            }
            return n;
        }

        public static int[] CompressArray(ref int[] arr)
        {
            int m = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) % 2 == 1)
                {
                    arr[m++] = arr[i];
                }
            }
            Array.Resize(ref arr, m);
            return arr;
        }

        public static int[] RandomArray(int n)
        {
            Random rnd = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-10, 11);
            }
            return arr;
        }

        public static void Print(int[] arr)
        {
            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input length of array");
            int n = Validate();
            int[] arr = RandomArray(n);
            Print(arr);
            CompressArray(ref arr);
            Print(arr);
        }
    }
}
