using System;

namespace Task_1
{
    interface IFigure
    {
        public double FindSquare { get;}
    }
    class Square : IFigure
    {
        double a;
        public Square(double a)
        {
            this.a = a;
        }
        public double FindSquare
        {
            get => a * a;
        }
        public override string ToString()
        {
            return "Square square = " + FindSquare;
        }
    }
    class Circle : IFigure
    {
        double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public double FindSquare
        {
            get => Math.PI * r * r;
        }
        public override string ToString()
        {
            return "Circle square = " + FindSquare;
        }
    }
    class Program
    {
        static void Info<T>(T[] arr, double p) where T : IFigure
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i].FindSquare > p)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = 10;
            int porog = 20;
            IFigure[] arr = new IFigure[n];
            for(int i = 0; i < n; i++)
            {
                double number = 1 + rnd.NextDouble() * 10;
                if(rnd.Next(2) == 0)
                {
                    arr[i] = new Circle(number);
                }
                else
                {
                    arr[i] = new Square(number);
                }
            }
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();
            Info(arr, porog);
        }
    }
}
