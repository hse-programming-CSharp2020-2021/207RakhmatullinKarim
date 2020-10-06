using System;

namespace Task_16
{
    class Program
    {
        const int LEFT = 1, RIGHT = 100;
        static void Main(string[] args)
        {
            int n = Validate();
            int[] arr = GenArr(n);
            Print(arr);
            MinAndMaxIndex(arr);

        }

        private static void MinAndMaxIndex(int[] arr)
        {
            int min = RIGHT + 1,
                max = LEFT - 1,
                iMax = 0,
                iMin = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    iMin = i;
                }
                else if (arr[i] > max)
                {
                    max = arr[i];
                    iMax = i;
                }
            }
            Console.WriteLine($"Index of minimum = {iMin}.");
            Console.WriteLine($"Sum of indexes of maximum " +
                $"and minimum = {iMax + iMin}.");
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
            Console.WriteLine("Input the length of array.");
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
