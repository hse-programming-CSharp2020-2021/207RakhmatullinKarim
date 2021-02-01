using System;

namespace task_1
{
    public delegate void SquareSizeChanged(double p);
    class Square
    {
        double hY, hX, dY, dX;
        public event SquareSizeChanged OnSizeChanged;
        public Square(double hX, double hY, double dX, double dY)
        {
            this.hX = hX;
            this.hY = hY;
            this.dX = dX;
            this.dY = dY;
        }
        double HY
        {
            get
            {
                return hY;
            }
            set
            {
                hY = value;
                OnSizeChanged?.Invoke(Math.Abs(hY - dY));
            }
        }
        double DX
        {
            get
            {
                return dX;
            }
            set
            {
                dX = value;
                OnSizeChanged?.Invoke(Math.Abs(hX - dX));
            }
        }
        double HX
        {
            get
            {
                return hX;
            }
            set
            {
                hX = value;
                OnSizeChanged?.Invoke(Math.Abs(hX - dX));
            }
        }
        double DY
        {
            get
            {
                return DY;
            }
            set
            {
                DY = value;
                OnSizeChanged?.Invoke(Math.Abs(hY - dY));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double hY, hX, dY, dX;
            Console.WriteLine("Input upper left point x");
            double.TryParse(Console.ReadLine(), out hX);
            Console.WriteLine("Input upper left point y");
            double.TryParse(Console.ReadLine(), out hY);
            Console.WriteLine("Input down right point x");
            double.TryParse(Console.ReadLine(), out dX);
            Console.WriteLine("Input down right point y");
            double.TryParse(Console.ReadLine(), out dY);
            Square s = new Square(hX, hY, dX, dY);
            s.OnSizeChanged += SquareConsoleInfo;
        }
        static void SquareConsoleInfo(double a)
        {
            Console.WriteLine($"{a:f2}");
        }
    }
}
