using System;

namespace Task_7_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrOfData = { { 20, 24, 25 }, { 21, 20, 18 }, { 23, 27, 24 }, { 22, 19, 20 } };
            string[] Filials = { "West", "Central", "East" };
            CountSailedCars(arrOfData);
            MaxCountSailed(arrOfData, Filials);
            MaxCountFil(arrOfData, Filials);
            SuccesfullKvartal(arrOfData);
        }

        private static void SuccesfullKvartal(int[,] arrOfData)
        {
            int maxSum = 0, kv = 0;
            for (int i = 0; i < arrOfData.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < arrOfData.GetLength(1); j++)
                {
                    sum += arrOfData[i, j];
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    kv = i;
                }
            }
            Console.WriteLine($"The most successfull is {kv + 1} kvartal, was sold {maxSum} cars.");
        }

        private static void MaxCountFil(int[,] arrOfData, string[] Filials)
        {
            int maxCntYear = 0, maxCntYearFil = -1;
            for (int i = 0; i < arrOfData.GetLength(1); i++)
            {
                int tmpCnt = 0;
                for (int j = 0; j < arrOfData.GetLength(0); j++)
                {
                    tmpCnt += arrOfData[j, i];
                }
                if (tmpCnt > maxCntYear)
                {
                    maxCntYear = tmpCnt;
                    maxCntYearFil = i;

                }
            }
            Console.WriteLine($"{Filials[maxCntYearFil]} filial sailed maximum of cars = {maxCntYear}");
        }

        private static void MaxCountSailed(int[,] arrOfData, string[] Filials)
        {
            int max = -1, maxFil = -1, maxkv = -1;
            for (int i = 0; i < arrOfData.GetLength(0); i++)
            {
                for (int j = 0; j < arrOfData.GetLength(1); j++)
                {
                    if (arrOfData[i, j] > max)
                    {
                        max = arrOfData[i, j];
                        maxFil = j;
                        maxkv = i + 1;
                    }
                }
            }
            Console.WriteLine($"Max count of sailed cars = {max}; filial {Filials[maxFil]}; {maxkv} kvartal.");
        }

        private static void CountSailedCars(int[,] arrOfData)
        {
            int sum = 0;
            foreach (int count in arrOfData)
            {
                sum += count;
            }
            Console.WriteLine($"Count of sailed cars {sum}");
        }
    }
}
