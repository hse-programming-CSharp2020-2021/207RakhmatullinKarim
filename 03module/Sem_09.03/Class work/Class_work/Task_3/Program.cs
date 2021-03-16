using System;
using System.IO;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream(@"../../../Program.cs", FileMode.Open))
            {
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, bytes.Length);
                string text = System.Text.Encoding.Default.GetString(bytes);
                Console.WriteLine(text);
                for(int i = 0; i < text.Length; i++)
                {
                    if (text[i] >= '0' && text[i] <= '9')
                        Console.WriteLine(text[i]);
                }
            }
            // Чтобы не переполнять буфер более оптимальный вариант
            using (FileStream inFi = new FileStream(@"../../../Program.cs", FileMode.Open))
            {
                int t;      // числовое значение прочитанного байта
                int k = 0;  // позиция байта в потоке (в файле)
                while ((t = inFi.ReadByte()) != -1)
                {
                    if (t >= (int)'0' && t <= (int)'9')
                        Console.WriteLine(t + " - " + (char)t + " - " + k);
                    k++;
                }   // while
            }     // using
        }
    }
}
