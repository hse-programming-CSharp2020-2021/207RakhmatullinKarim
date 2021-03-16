using System;

namespace Task_9_p_17
{
    class Program
    {
        const int N = 10;
        public static int FindMax(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < N; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

            }
            return max;
        }

        static public int[] ArrayChanger(int[] arr, int param)
        {
            int max = FindMax(arr);
            for(int i = 0; i < N; i++)
            {
                if(arr[i] == max)
                {
                    arr[i] = param;
                }
            }
            return arr;
        }

        static public void Printer(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arr = new int[N];
            Random rnd = new Random();
            for(int i = 0; i < N; i++)
            {
                arr[i] = rnd.Next(1, 101);
            }
            int param;
            Console.WriteLine("Input the parametr");
            while(!int.TryParse(Console.ReadLine(), out param))
            {
                Console.WriteLine("Try again");
            }
            Printer(arr);
            Printer(ArrayChanger(arr, param));
        }
    }
}
