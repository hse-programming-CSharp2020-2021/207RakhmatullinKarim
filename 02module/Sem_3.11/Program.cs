using System;

namespace Task_7
{
    class Program
    {
        class Sin
        {
            double Xmin, Xmax;
            public Sin(double min, double max)
            {
                Xmin = min;
                Xmax = max;
            }
            public double this[double index]
            {
                get
                {
                    if((index < 0) || (index > Xmax))
                    {
                        throw new ArgumentException("Index out of range.");
                    }
                    return Math.Sin(Xmin + Math.PI / 6 * index);
                }
            }
        }
        static void Main(string[] args)
        {
            Sin f = new Sin(0, Math.PI);
            for(double i = 0; i < Math.PI; i += Math.PI / 6)
            {
                Console.WriteLine(f[i]);
            }
        }
    }
}
