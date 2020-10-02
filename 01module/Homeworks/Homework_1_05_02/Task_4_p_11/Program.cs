using System;

namespace Task_4_p_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a0;
            a0 = ValidateInput();
            int k = CountElements(a0);
            int[] resArr = GenerateArray(a0, k);
            Print(resArr);
        }

        public static int[] GenerateArray(int a0, int k)
        {
            int[] resArr = new int[k];
            resArr[0] = a0;
            int aPrevious;
            for (int i = 1; i < k; i++)
            {
                aPrevious = resArr[i - 1];
                resArr[i] = aPrevious % 2 == 0 ? aPrevious / 2 :
                    (3 * aPrevious + 1);
            }

            return resArr;
        }

        public static int CountElements(int a0)
        {
            int aPrevious = a0,
                aLast = 0,
                k = 1;
            while (aLast != 1)
            {
                aLast = aPrevious % 2 == 0 ? aPrevious / 2 :
                    (3 * aPrevious + 1);
                aPrevious = aLast;
                k++;
            }

            return k;
        }

        public static void Print(int[] arr)
        {
            for(int i = 0; i < arr.Length / 5; i++)
            {
                for(int j = i * 5; j < i * 5 + 5; j++)
                {
                    Console.Write($"[{j}] = {arr[j]} ");
                }
                Console.WriteLine();
            }
            for(int i = (arr.Length / 5) * 5; i < arr.Length; i++)
            {
                Console.Write($"[{i}] = {arr[i]} ");
            }
            Console.WriteLine();
        }

        public static int ValidateInput()
        {
            int a0;
            Console.WriteLine("Input the first element.");
            while ((!int.TryParse(Console.ReadLine(), out a0)) || (a0 < 0))
            {
                Console.WriteLine("Incorrect input. Try again.");
            }

            return a0;
        }
    }
}
