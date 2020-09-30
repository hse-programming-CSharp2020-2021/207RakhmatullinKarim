using System;

namespace Exersize_1
{
    class Program
    {
        const int L = 10, R = 50;
        static public int[] Generating(int length)
        {
            int[] input = new int[length];
            Random r = new Random();
            for (int i = 0; i < length; i++)
            {
                input[i] = r.Next(L, R + 1);
            }
            return input;
        }
        static public int[] Result(int[] arr1, int[] arr2)
        {
            int[] res = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                res[i] = arr1[i];
            }
            for (int i = arr1.Length; i < arr1.Length + arr2.Length; i++)
            {
                if (arr2[i - arr1.Length] % 2 == 0)
                {
                    res[i] = arr2[i - arr1.Length];
                }
            }
            return res;
        }

        static public void Printer(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            int a, b;
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            int[] arr1 = Generating(a);
            int[] arr2 = Generating(b);
            Printer(arr1);
            Console.WriteLine();
            Printer(arr2);
            Console.WriteLine();
            Printer(Result(arr1, arr2));

        }
    }
}
