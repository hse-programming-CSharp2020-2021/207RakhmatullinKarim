using System;
using System.Collections.Generic;

namespace Task_11
{
    class GeometricProgression
    {
        double _start;
        double _increment;
        public GeometricProgression()
        {
            _start = 0;
            _increment = 1;
        }
        public GeometricProgression(double _start, double _increment)
        {
            this._start = _start;
            this._increment = _increment;
        }
        public double this[int index]
        {
            get
            {
                return _start * Math.Pow(_increment, index);
            }
        }
        public string GetInfo()
        {
            return $"start element = {_start:f2} increment = {_increment:f2}";
        }
        public double GetSum(int n)
        {
            return _start * (Math.Pow(_increment, n) - 1) / (_increment - 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyToExit = new ConsoleKeyInfo();
            Random rnd = new Random();
            do
            {
                int n = rnd.Next(5, 16);
                GeometricProgression gp1 = new GeometricProgression(10 * rnd.NextDouble(), 5 * rnd.NextDouble() + 0.000001);
                Console.WriteLine($"New Gp: {gp1.GetInfo()}");
                Console.WriteLine();
                GeometricProgression[] arrOfGp = new GeometricProgression[n];
                GenerateArrOfGp(arrOfGp);
                int step = rnd.Next(3, 16);
                Console.WriteLine("Step = " + step);
                for(int i = 0; i < arrOfGp.Length; i++)
                {
                    if(arrOfGp[i][step] > gp1[step])
                    {
                        Console.WriteLine(arrOfGp[i].GetInfo());
                    }
                }
                for (int i = 0; i < arrOfGp.Length; i++)
                {
                    Console.WriteLine($"{arrOfGp[i].GetSum(step):f2}");
                }
                Console.WriteLine("Press 'Escape' to exit.");
                keyToExit = Console.ReadKey();
            } while (keyToExit.Key != ConsoleKey.Escape);

        }

        private static void GenerateArrOfGp(GeometricProgression[] arrOfGp)
        {
            Random rnd = new Random();
            for (int i = 0; i < arrOfGp.Length; i++)
            {
                arrOfGp[i] = new GeometricProgression(10 * rnd.NextDouble(), 5 * rnd.NextDouble() + 0.000001);
                Console.WriteLine(arrOfGp[i].GetInfo());
            }
            Console.WriteLine();
        }

    }
}
