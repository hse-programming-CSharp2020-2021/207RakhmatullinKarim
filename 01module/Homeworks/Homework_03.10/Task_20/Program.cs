using System;

namespace Task_20
{
    class Program
    {
        const int LEFT = 10, RIGHT = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Input the length of array.");
            int n = Validate();
            Console.WriteLine("Input y");
            int y = Validate();
            int[] arr = GenArr(n);
            Print(arr);
            ArrayItemDouble(ref arr, y);
            Print(arr);
        }

        private static void ArrayItemDouble(ref int[] arr, int y)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == y)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    for (int j = arr.Length - 1; j > i; j--)
                    {
                        arr[j] = arr[j - 1];
                    }
                    i++;
                }
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
            while ((!int.TryParse(Console.ReadLine(), out n)) || (n < 1))
            {
                Console.WriteLine("Error. Try again.");
            }

            return n;
        }

        public static int[] GenArr(int n)
        {
            int[] arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(LEFT, RIGHT + 1);
            }

            return arr;
        }
    }
}
