using System;

namespace Num_1
{
    class Program
    {
        static public int[] Generating(int length, int a, int b) {
            int[] input = new int[length];
            Random r = new Random();
            for (int i = 0; i < length; i++)
            {
                input[i] = r.Next(a, b + 1);
            }
            return input;
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
            int n = 10;
            int[] a = Generating(n, 1, 100);
            Printer(a);

        }
    }
}
