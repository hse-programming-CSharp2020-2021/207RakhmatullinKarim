using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyToExit = new ConsoleKeyInfo();
            do
            {
                try
                {
                    string[] input = MyAbbreviation.ValidatedSplit(Console.ReadLine(), ';');
                    for(int i = 0; i < input.Length; i++)
                    {
                        Console.WriteLine(MyAbbreviation.Abbrevation(input[i]));
                    }
                }
                catch(NullReferenceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Press 'Escape' to exit.");
                keyToExit = Console.ReadKey();
            } while (keyToExit.Key != ConsoleKey.Escape);
        }
    }
}
