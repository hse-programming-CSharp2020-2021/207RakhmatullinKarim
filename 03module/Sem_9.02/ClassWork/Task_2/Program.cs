using System;
using System.Collections.Generic;
using System.Linq;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (char ch in data.ToCharArray())
            {
                if ((ch == '(') || (ch == '{') || (ch == '['))
                    stack.Push(ch);
                else
                {
                    char el = stack.Pop();
                    if(!((ch == ')' && el == '(') || (ch == '}' && el == '{')
                        || (ch == ']' && el == '[')))
                    {
                        stack.Push(ch);
                        break;
                    }
                }
            }
            if(stack.Count == 0)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
