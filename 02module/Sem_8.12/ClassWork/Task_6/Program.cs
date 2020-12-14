using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(String.Join(" ", input.Split(' ', StringSplitOptions.RemoveEmptyEntries)));
            
        }
    }
}
