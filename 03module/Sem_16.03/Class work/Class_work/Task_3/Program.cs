using System;
using System.IO;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd= new Random();
            FileStream fs = new FileStream(@"..\..\..\Test.txt", FileMode.OpenOrCreate);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                for(int i = 0; i < 100; i++)
                {
                    writer.WriteLine(100 + rnd.NextDouble() * 900);
                }
            }
            using (StreamReader reader = new StreamReader(@"..\..\..\Test.txt"))
            {
                Console.SetIn(reader);
                double sum = 0;
                for(int i = 0; i < 100; i++)
                {
                    double.TryParse(Console.ReadLine(), out double x);
                    sum += x;
                }
                Console.WriteLine(sum / 100);
                Console.SetIn(new StreamReader(Console.OpenStandardInput()));
            }
        }
    }
}
