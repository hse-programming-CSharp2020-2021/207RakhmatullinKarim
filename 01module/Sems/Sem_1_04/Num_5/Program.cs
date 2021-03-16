using System;

namespace Num_5
{
    class Program
    {
        public static double Sum(int k, ref double s)
        {
            s += (k + 0.3) / (3 * k * k + 5);
        }
        static void Main(string[] args)
        {
            int k;
            if(!int.TryParse(Console.ReadLine(), out k) || (k <= 0))
            {
                Console.WriteLine("Error");
                return;
            }
            for(int i = 1;i < k + 1; i++)
            {
                Console.Write(i + " " + '\t' + );
            }
        }
    }
}
