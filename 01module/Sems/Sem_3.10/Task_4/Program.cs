using System;

namespace Task_4
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
            int k = 0;
            int[] arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-10, 11);
            }
            Print(arr);
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 0)
                {
                    int tmp = arr[i],
                        j = i;
                    while(j < arr.Length - 1)
                    {
                        arr[j] = arr[j + 1];
                        j++;
                    }
                }
            }
            Print(arr);

        }

        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
