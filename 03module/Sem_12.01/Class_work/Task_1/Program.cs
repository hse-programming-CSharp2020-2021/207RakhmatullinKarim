using System;

namespace Task_1
{
    class Program
    {
        delegate int[] digitsDel(int number);
        delegate void PrintArrDel(int[] arr);
        static int[] digits(int number)
        {
            int cnt = 0;
            int tmp = number;
            while(tmp > 0)
            {
                tmp /= 10;
                cnt++;
            }
            int[] digits = new int[cnt];
            for(int i = cnt - 1; i >= 0; i--)
            {
                digits[i] = number % 10;
                number /= 10;
            }
            return digits;
        }
        static void PrintArr(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int n = 34253;
            int[] arr = { 12, 54, 93, 99, 36, 10, 35, 82, 53, 39 };
            digitsDel del1 = digits;
            PrintArrDel del2 = PrintArr;
            del2(del1(n));
            Console.WriteLine("Delegates info");
            Console.WriteLine(del1.Method);
            Console.WriteLine(del1.Target);
            Console.WriteLine();
            Console.WriteLine(del2.Method);
            Console.WriteLine(del2.Target);
        }
    }
}
