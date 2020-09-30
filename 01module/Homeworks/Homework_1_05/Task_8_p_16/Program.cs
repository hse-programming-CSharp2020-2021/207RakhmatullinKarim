using System;

namespace Task_8_p_16
{
    class Program
    {
        public static double[] GenerateArr(int n)
        {
            double[] arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = ((i * (i + 1)) / 2) % n;
            }
            return arr;
        }

        public static double[] ArrToNormal(double[] arr)
        {
            double max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }

            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] /= max;
            }
            return arr;
        }

        static public void Printer(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]:f3} ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Input the length of array.");
            while ((!int.TryParse(Console.ReadLine(), out n)) || (n < 1))
            {
                Console.WriteLine("Try again");
            }
            double[] array = GenerateArr(n);
            Printer(array);
            double[] normalArray = ArrToNormal(array);
            Printer(normalArray);



        }
    }
}

