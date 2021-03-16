using System;

namespace Task_2
{
    interface ISequence
    {
        public double GetElement(int number);
    }
    class ArithmeticProgression : ISequence
    {
        double first;
        double d;
        public ArithmeticProgression(double first, double d)
        {
            this.first = first;
            this.d = d;
        }
        public double GetElement(int number)
        {
            return first + d * (number - 1);
        }
    }
    class GeometricProgression : ISequence
    {
        double first;
        double q;
        public GeometricProgression(double first, double q)
        {
            this.first = first;
            this.q = q;
        }
        public double GetElement(int number)
        {
            return first * Math.Pow(q, number - 1);
        }
    }
    class Program
    {
        public static double Sum(ISequence sequence, int number)
        {
            double res = 0;
            for (int i = 0; i < number; i++)
            {
                res += sequence.GetElement(i);
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(new ArithmeticProgression(3, 5), 10));
            Console.WriteLine(Sum(new GeometricProgression(3, 5), 10));
        }
    }
}
