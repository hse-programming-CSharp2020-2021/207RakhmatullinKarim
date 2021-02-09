using System;
using System.Collections.Generic;
namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number, tmp;
            int.TryParse(input, out number);
            tmp = number;
            LinkedList<int> link = new LinkedList<int>();
            for(int i = 0; i < input.Length; i++)
            {
                link.AddFirst(tmp % 10);
                tmp /= 10;
            }
            foreach(int digit in link)
            {
                Console.Write(digit + " ");
            }
            Console.WriteLine();
            Stack<int> stack = new Stack<int>();
            tmp = number;
            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(tmp % 10);
                tmp /= 10;
            }
            foreach (int digit in stack)
            {
                Console.Write(digit + " ");
            }

        }
    }
}
