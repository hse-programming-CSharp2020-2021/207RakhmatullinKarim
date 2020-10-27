using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            count = Validate();
            int[] arrOfNumbers = FillArr(count);
            int min;
            Console.Write("Generated array: ");
            PrintArr(arrOfNumbers);
            Console.Write("Prime numbers: ");
            PrintArr(Primes(arrOfNumbers));
            if (IsNonDecreasing(arrOfNumbers, out min))
            {
                Console.WriteLine("Is non decreasing.");
            }
            else
            {
                Console.WriteLine("Is not non decreasing.");
            }
            Console.WriteLine("min = " + min);


        }

        private static int Validate()
        {
            int count;
            do
            {
                Console.WriteLine("Input count of numbers");
            } while ((!int.TryParse(Console.ReadLine(), out count)) || (count < 1));
            return count;
        }

        private static bool IsNonDecreasing(int[] arrOfNumbers, out int min)
        {
            bool isNonDecreasing = true;
            for (int i = 0; i < arrOfNumbers.Length - 1; i++)
            {
                if (arrOfNumbers[i + 1] < arrOfNumbers[i])
                {
                    isNonDecreasing = false;
                    break;
                }
            }
            min = arrOfNumbers[0];
            if (!isNonDecreasing)
            {
                for(int i = 0; i < arrOfNumbers.Length; i++)
                {
                    if(arrOfNumbers[i] < min)
                    {
                        min = arrOfNumbers[i];
                    }
                }
            }
            return isNonDecreasing;
        }

        private static int[] FillArr(int count)
        {
            Random rnd = new Random();
            int[] arrOfNumbers = new int[count];
            for (int i = 0; i < arrOfNumbers.Length; i++)
            {
                arrOfNumbers[i] = rnd.Next(1, 101);
            }

            return arrOfNumbers;
        }

        private static int[] Primes(int[] arrOfNumbers)
        {
            int countOfPrime = 0;
            for (int i = 0; i < arrOfNumbers.Length; i++)
            {
                if (IsPrime(arrOfNumbers[i]))
                {
                    countOfPrime++;
                }
            }
            int j = 0;
            int[] arrOfPrimes = new int[countOfPrime];
            for (int i = 0; i < arrOfNumbers.Length; i++)
            {
                if (IsPrime(arrOfNumbers[i]))
                {
                    arrOfPrimes[j++] = arrOfNumbers[i];
                }
            }
            return arrOfPrimes;
        }

        private static void PrintArr(int[] arrOfNumbers)
        {
            foreach (int item in arrOfNumbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static bool IsPrime(int number)
        {
            bool isPrime = true;
            if ((number != 2) && (number != 1))
            {
                for (int i = 2; i <= Math.Round(Math.Sqrt(number)); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            return isPrime;
        }
        
    }
}
