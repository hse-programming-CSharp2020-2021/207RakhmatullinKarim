using System;

namespace Task_8
{
    class Point
    {
        double x;
        double y;
        public Point() { }
        public double dest(double x1, double y1)
        {
            double deltaX = x - x1;
            double deltaY = y - y1;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double X
        {
            get
            {
                return x;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
        }

    }
    class Triangle
    {
        Point A;
        Point B;
        Point C;
        public Triangle() { }
        public Triangle(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            this.A = new Point(x1, y1);
            this.B = new Point(x2, y2);
            this.C = new Point(x3, y3);
        }
        public double AB
        {
            get
            {
                return A.dest(B.X, B.Y);
            }
        }
        public double BC
        {
            get
            {
                return B.dest(C.X, C.Y);
            }
        }
        public double AC
        {
            get
            {
                return A.dest(C.X, C.Y);
            }
        }
        public double Perimetr
        {
            get { return AB + AC + BC; }
        }
        public double Square
        {
            get
            {
                double halfP = (AB + BC + AC) / 2;
                return Math.Sqrt(halfP * (halfP - AB) * (halfP - BC) * (halfP - AC));
            }
        }
        public override string ToString()
        {
            string res = $"AB = {AB:f2} BC = {BC:f2} AC = {AC:f2} Perimetr = {Perimetr:f2} Square = {Square:f2}";
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Random rnd = new Random();
            n = rnd.Next(5, 16);
            Triangle[] arrOfTriangle = new Triangle[n];
            for (int i = 0; i < n; i++)
            {
                Point A = new Point(-10 + rnd.NextDouble() * (10 - (-10)), -10 + rnd.NextDouble() * (10 - (-10)));
                Point B = new Point(-10 + rnd.NextDouble() * (10 - (-10)), -10 + rnd.NextDouble() * (10 - (-10)));
                Point C = new Point(-10 + rnd.NextDouble() * (10 - (-10)), -10 + rnd.NextDouble() * (10 - (-10)));
                arrOfTriangle[i] = new Triangle(A, B, C);
            }
            for (int i = 0; i < arrOfTriangle.Length; i++)
            {
                Console.WriteLine(arrOfTriangle[i].ToString());
            }
            Console.WriteLine();
            SortSquares(arrOfTriangle);
            for (int i = 0; i < arrOfTriangle.Length; i++)
            {
                Console.WriteLine(arrOfTriangle[i].ToString());
            }
        }

        private static void SortSquares(Triangle[] arrOfTriangle)
        {
            for (int i = arrOfTriangle.Length - 1; i > 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arrOfTriangle[i].Square > arrOfTriangle[j].Square)
                    {
                        Triangle tmp = arrOfTriangle[i];
                        arrOfTriangle[i] = arrOfTriangle[j];
                        arrOfTriangle[j] = tmp;
                    }
                }
            }
        }
    }
}
