using System;

namespace Task_2
{
    class Program
    {
        class LatinChar
        {
            char _char;
            public LatinChar(char ch = 'a')
            {
                _char = ch;
            }

            public char Ch
            {
                get
                {
                    return _char;
                }
                set
                {
                    if((value < 'a') && (value > 'z'))
                    {
                        throw new ArgumentException("Incorrect symbol.");
                    }
                    else
                    {
                        _char = value;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input minChar");
            char minCh;
            Char.TryParse(Console.ReadLine(), out minCh);
            Console.WriteLine("Input maxChar");
            char maxCh;
            Char.TryParse(Console.ReadLine(), out maxCh);
            LatinChar ch = new LatinChar();
            for(int i = minCh; i <= maxCh; i++)
            {
                try
                {
                    ch = new LatinChar((char)i);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine(ch.Ch);
            }
            
        }
    }
}
