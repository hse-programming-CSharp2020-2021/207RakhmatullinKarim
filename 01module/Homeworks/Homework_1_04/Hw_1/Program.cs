using System;

namespace Hw_1
{
    class Program
    {
        const int LEFT = 1,
                  RIGHT = 20;
        static void Main(string[] args)
        {
            NewMethod();
        }

        private static void NewMethod()
        {
            for (int i = LEFT; i < RIGHT; i++)
            {
                for (int j = i + 1; j < RIGHT + 1; j++)
                {
                    int c = Convert.ToInt32(Math.Round(Math.Sqrt(i * i + j * j)));
                    if ((c < 21) && (c > 0) && (c != i) && (c != j) &&
                        ((i * i + j * j) == c * c)){
                        Console.WriteLine($"{i}^2 + {j}^2 = {c}^2");
                    }
                }
            }
        }
    }
}
