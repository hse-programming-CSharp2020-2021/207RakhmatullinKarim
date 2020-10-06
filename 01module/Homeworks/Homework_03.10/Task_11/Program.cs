using System;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Validate();
            int[] arr = GenerateArr(n);
            Print(arr);
        }

        public static int GenNumber(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else
            {
                int sum = 0,
                    sBegin = 0,
                    sPrevious = 1;
                for (int i = 1; i < n; i++)
                {
                    sum = 34 * sPrevious - sBegin + 2;
                    sBegin = sPrevious;
                    sPrevious = sum;
                }
                return sum;

            }
        }

        public static int[] GenerateArr(int length)
        {
            int[] arr = new int[length];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = GenNumber(i);
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
    }
}
