using System;

namespace Sem_4
{
    class Program
    {
        public static bool Shift(ref char ch)
        {
            if (!(((int)ch >= (int)('a')) && ((int)ch < ((int)('z') + 1))) ||
                !char.TryParse(Console.ReadLine(), out ch))
            {
                Console.WriteLine("Error");
                return false;
            }
            ch = (char)(((int)ch - int('a') + 4) % 26);
            return true;

        }
        static void Main(string[] args)
        {
            char ch;
            if (!char.TryParse(Console.ReadLine(), out ch) ||
                !(((char)ch > 'a') && ((char)ch < ('z' + 1))))
            {
                Console.WriteLine("Error");
                return;
            }
            if (Shift(ref ch))
            {
                Console.WriteLine((char)ch);
            }
        }
    }
}
