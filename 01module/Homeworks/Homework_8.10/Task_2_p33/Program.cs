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
            WritePowArr(pathToWrite, A);
        }

        private static void WritePowArr(string pathToWrite, int[] A)
        {
            int[] B = new int[A.Length];
            File.WriteAllText(pathToWrite, string.Empty);
            for (int i = 0; i < B.Length; i++)
            {
                int powOfTwo = 0;
                while((1 << powOfTwo) <= A[i])
                {
                    powOfTwo++;
                }
                B[i] = 1 << --powOfTwo;
                File.AppendAllText(pathToWrite, B[i].ToString() + '\n');
            }
        }

        private static int[] ReadArray(string pathToRead)
        {
            Random rnd = new Random();
            int length = rnd.Next(10);
            File.WriteAllText(pathToRead, string.Empty);
            int[] A = new int[length];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rnd.Next(1, 10001);
                File.AppendAllText(pathToRead, A[i].ToString() + '\n');
            }

            return A;
        }
    }
}
