using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            int[][] paskal = new int[n][];
            paskal[0] = new int[1] { 1 };
            paskal[1] = new int[2] { 1, 1 };
            for(int i = 2; i < n; i++)
            {
                paskal[i] = new int[i + 1];
                paskal[i][0] = 1;
                paskal[i][i] = 1;
                for(int j = 1; j < i; j++)
                {
                    paskal[i][j] = paskal[i - 1][j - 1] + paskal[i - 1][j];
                }
            }
            foreach(int[] ar in paskal)
            {
                foreach(int cnk in ar)
                {
                    Console.Write(cnk + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
