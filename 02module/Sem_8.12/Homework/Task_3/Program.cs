using System;
using System.IO;

namespace Task_3
{
    class Program
    {
        static int[] stat = new int[26];
        static int openBrackets = 0; // количество {
        static int closedBrackets = 0; // количество }
        static int total = 0; // общее количество символов файла
        static void Main(string[] args)
        {
            try
            {
                using (var streamReader = new StreamReader(@"../../../Program.cs"))
                {
                    Console.SetIn(streamReader);
                    string tmp;
                    while ((tmp = Console.ReadLine()) != null)
                    {
                        BracketsCount(tmp);
                    }
                }
                using (StreamWriter sw = new StreamWriter("Output.txt"))
                {
                    for (int i = 0; i < 26; i++)
                    {
                        sw.WriteLine($"{(char)('a' + i)} - {stat[i]}");
                    }
                    if (openBrackets == closedBrackets)
                        sw.WriteLine("Баланс скобок соблюдён, количество блоков " + closedBrackets);

                    sw.WriteLine("Total amount of symbols: " + total);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.SetIn(new StreamReader(Console.OpenStandardInput()));
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
            Console.WriteLine("Для завершения работы нажмите любую клавишу.");
            Console.ReadLine();
        }
        /// <summary>
        /// Вычисляет количество открывающихся и закрывающихся скобок в строке
        /// </summary>
        /// <param name="tmp">строка символов</param>
        static void BracketsCount(string tmp)
        {
            total += tmp.Length;
            foreach (char symbol in tmp)
            {
                bool isString = false;
                if (symbol >= 'a' && symbol <= 'z')
                    stat[symbol - 'a'] += 1;
                if (symbol == '"')
                {
                    isString = !isString;
                }
                else if (symbol == '{')
                {
                    if (!isString)
                    {
                        openBrackets++;
                    }
                }
                else if (symbol == '}')
                {
                    if (!isString)
                    {
                        closedBrackets++;
                    }
                }
            }
        }


    }
}
