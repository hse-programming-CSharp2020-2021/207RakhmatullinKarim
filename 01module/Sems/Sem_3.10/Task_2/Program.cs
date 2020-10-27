using System;

namespace Task_2
{
    class Program
    {
        public static int Validate()
        {
            int n;
            Console.WriteLine("Input length of array");
            while ((!int.TryParse(Console.ReadLine(), out n)) || (n <= 0))
            {
                Console.WriteLine("Error. Try again");
            }

            return n;
        }

        static void Main(string[] args)
        {
            int n = Validate();
            int length = n;
            int[][] arr = new int[n][];
            for(int i = 0; i < n; i++)
            {
                arr[i] = new int[i + 1];
                for(int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = length--;
                    if(length == 0)
                    {
                        break;
                    }
                }
                if (length == 0)
                {
                    break;
                }
            }
            for(int i = 0; i < length; i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"{arr[i][j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
