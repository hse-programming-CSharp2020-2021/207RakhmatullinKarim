using System;

namespace Task_2_p_5
{
    class Program
    {
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
            while ((!int.TryParse(Console.ReadLine(), out n)) || (n <= 0))
            {
                Console.WriteLine("Error. Try again.");
            }
            return n;
        }

        public static char[] RandomArray(int n)
        {
            Random rnd = new Random();
            char[] arr = new char[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = (char)('A' + rnd.Next(0, 26));
            }
            return arr;
        }

        public static void Print(char[] arr)
        {
            foreach (int a in arr)
            {
                Console.Write((char)a + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input length of array");
            int n = Validate();
            char[] arr = RandomArray(n);
            Print(arr);
            char[] copyArr = new char[arr.Length];
            Array.Copy(arr, copyArr, arr.Length);
            Array.Sort(copyArr);
            Print(copyArr);
            Array.Reverse(copyArr);
            Print(copyArr);

        }
    }
}
