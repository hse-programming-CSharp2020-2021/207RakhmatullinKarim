using System;

namespace Task_2
{
    class Program
    {
        public static int[] RandomArray(int n)
        {
            Random rnd = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(10, 51);
            }
            return arr;

        }

        public static int[] Changer(int[] arrA, int[] arrB)
        {
            int[] modifiedArrA = new int[arrA.Length + arrB.Length];
            for(int i = 0; i < arrA.Length; i++)
            {
                modifiedArrA[i] = arrA[i];
            }
            int m = arrA.Length;
            for(int i = 0; i < arrB.Length; i++)
            {
                if(arrB[i] % 2 == 0)
                {
                    modifiedArrA[m++] = arrB[i];
                }
            }
            Array.Resize(ref modifiedArrA, m);
            return modifiedArrA;
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
            while ((!int.TryParse(Console.ReadLine(), out n)) || (n <= 0))
            {
                Console.WriteLine("Error. Try again.");
            }
            return n;
        }

        static void Main(string[] args)
        {

            int lengthOfA, lengthOfB;
            Console.WriteLine("Input length of Array A.");
            lengthOfA = Validate();
            Console.WriteLine("Input length of array B");
            lengthOfB = Validate();
            int[] arrA = RandomArray(lengthOfA);
            int[] arrB = RandomArray(lengthOfB);
            Console.Write("Array A: \t\t");
            Print(arrA);
            Console.Write("Array B: \t\t");
            Print(arrB);
            Console.Write("Modified array A: \t");
            Print(Changer(arrA, arrB));

        }
    }
}
