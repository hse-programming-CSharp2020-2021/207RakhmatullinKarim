using System;

namespace Hw_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number.");
            NewMethod();
        }

        private static void NewMethod()
        {
            double sum = 0, k = 0;
            ConsoleKeyInfo keyToExit;
            do
            {
                int x;
                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Incorrect input, try again.");
                }
                if (x < 0)
                {
                    sum += x;
                    k++;
                }
                Console.WriteLine("To exit press Escape, to continue press" +
                    " any other button");
                keyToExit = Console.ReadKey();
                Console.WriteLine();
            } while ((sum >= -1000) && (keyToExit.Key != ConsoleKey.Escape));
            Console.Clear();
            Console.WriteLine($"Average = {sum / k:f3}");
        }
    }
}
