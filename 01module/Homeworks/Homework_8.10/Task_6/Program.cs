using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            input = Console.ReadLine();
            string[] elements = input.Split(';');
            int countElem = 0;
            CountInt(elements, ref countElem);
            int[] arrOfNum = new int[countElem];
            FillArr(elements, ref arrOfNum);
            PrintArr(arrOfNum);
            Average(arrOfNum);
        }

        private static void Average(int[] arrOfNum)
        {
            int sum = 0;
            for (int i = 0; i < arrOfNum.Length; i++)
            {
                sum += arrOfNum[i];
            }
            Console.WriteLine("Average = " + sum / arrOfNum.Length);
        }

        private static void PrintArr(int[] arrOfNum)
        {
            foreach (int item in arrOfNum)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static int FillArr(string[] elements, ref int[] arrOfNum)
        {
            int x, tmp = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                if (int.TryParse(elements[i], out x))
                {
                    arrOfNum[tmp++] = x;
                }
            }

            return tmp;
        }

        private static void CountInt(string[] elements, ref int countElem)
        {
            int x;
            for (int i = 0; i < elements.Length; i++)
            {
                if (int.TryParse(elements[i], out x))
                {
                    countElem++;
                }
            }
        }
    }
}
