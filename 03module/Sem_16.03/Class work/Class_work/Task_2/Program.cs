using System;
using System.IO;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            BinaryWriter fOut = new BinaryWriter(new FileStream("../../../t.dat", FileMode.Create));
            for (int i = 0; i < 10; i++)
                fOut.Write(rnd.Next(1, 101));
            fOut.Close();

            List<int> arr = new List<int>();
            FileStream f = new FileStream("../../../t.dat", FileMode.Open);
            BinaryReader fIn = new BinaryReader(f);
            long n = f.Length / 4; int a;
            for (int i = 0; i < n; i++)
            {
                arr.Add(fIn.ReadInt32());
            }
            fIn.Close();

            bool contains = false;
            int x = 0;
            int.TryParse(Console.ReadLine(), out x);
            for (int i = 0; i < 100 - x; i++)
            {
                if (arr.Contains(x + i) && !contains)
                {
                    arr[arr.IndexOf(x + i)] = x;
                    contains = true;
                }
            }

            fOut = new BinaryWriter(new FileStream("../../../t.dat", FileMode.Create));
            foreach(int num in arr)
                fOut.Write(num);
            fOut.Close();
        }
    }
}
