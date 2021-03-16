using System;

namespace Task_1
{
    class Program
    {
        public static void Print(char[] arr)
        {
            foreach(int a in arr)
            {
                Console.Write((char)a + " ");
            }
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

        public static char[] DigitsArray(int n)
        {
            int k = CountDigits(n);
            char[] arr = new char[k];
            for (int i = k - 1; i >= 0; i--)
            {
                arr[i] = (char)(n % 10 + '0');
                n /= 10;
            }
            return arr;

        }

        public static int CountDigits(int n)
        {
            int tmp, k = 0;
            tmp = n;
            while (tmp > 0)
            {
                k++;
                tmp /= 10;
            }

            return k;
        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Input number");
            n = Validate();
            Print(DigitsArray(n));

        }
    }
}
