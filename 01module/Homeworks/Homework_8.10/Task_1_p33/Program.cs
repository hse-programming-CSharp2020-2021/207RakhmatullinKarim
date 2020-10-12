using System;
using System.IO;

namespace Task_1_p33
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathToRead = "input.txt";
            string pathToWrite = "output.txt";
            int[] A = ReadArray(pathToRead);
            WriteBoolArr(pathToWrite, A);
        }

        private static void WriteBoolArr(string pathToWrite, int[] A)
        {
            bool[] L = new bool[A.Length];
            for (int i = 0; i < L.Length; i++)
            {
                if (A[i] > 0)
                {
                    L[i] = true;
                }
                else
                {
                    L[i] = false;
                }
                File.AppendAllText(pathToWrite, L[i].ToString() + '\n');
            }
        }

        private static int[] ReadArray(string pathToRead)
        {
            Random rnd = new Random();
            int length = rnd.Next(10, 21);
            File.WriteAllText(pathToRead, string.Empty);
            int[] A = new int[length];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rnd.Next(-10, 11);
                File.AppendAllText(pathToRead, A[i].ToString() + '\n');
            }

            return A;
        }
    }
}
