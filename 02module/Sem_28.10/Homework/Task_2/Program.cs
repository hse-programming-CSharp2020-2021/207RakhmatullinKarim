using System;

namespace Task_2
{
    class Program
    {
        class Point
        {
            double X;
            double Y;
            public Point()
            {
                X = 0;
                Y = 0;
            }
            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
            public double Fi
            {
                get
                {
                    if (X > 0)
                    {
                        if (Y >= 0)
                        {
                            return Math.Atan(Y / X);

                        }
                        else
                        {
                            return Math.Atan(Y / X) + 2 * Math.PI;
                        }
                    }
                    else if (X < 0)
                    {
                        return Math.Atan(Y / X) + Math.PI;
                    }
                    else
                    {
                        if (Y > 0)
                        {
                            return Math.PI / 2;
                        }
                        else if (Y == 0)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3 * Math.PI / 2;
                        }
                    }
                }
            }
            public double Ro
            {
                get
                {
                    return Math.Sqrt(Y * Y + X * X);
                }
            }
            public string DataOfPoint
            {
                get
                {
                    return $"X = {X:f2} Y = {Y:f2} Fi = {Fi:f2} Ro = {Ro:f2}";
                }
            }
        }
        static void Main(string[] args)
        {
            Point point1 = new Point(5, 2.5);
            Point point2 = new Point(-3.2, 2.9);
            double x = 0,
                y = 0;
            do
            {
                Console.WriteLine("Input x");
                Validate(ref x);
                Console.WriteLine("Input y");
                Validate(ref y);
                Point point3 = new Point(x, y);
                SortPoints(ref point1, ref point2, ref point3);
                Console.WriteLine(point1.DataOfPoint);
                Console.WriteLine(point2.DataOfPoint);
                Console.WriteLine(point3.DataOfPoint);
            } while ((x != 0) | (y != 0));
        }

        private static void SortPoints(ref Point point1, ref Point point2, ref Point point3)
        {
            Point pointTmp;
            if (point1.Ro > point2.Ro)
            {
                if (point1.Ro > point3.Ro)
                {
                    pointTmp = point1;
                    point1 = point3;
                    point3 = pointTmp;
                }
            }
            if (point2.Ro > point3.Ro)
            {
                pointTmp = point2;
                point2 = point3;
                point3 = pointTmp;
            }
            if (point1.Ro > point2.Ro)
            {
                pointTmp = point2;
                point2 = point1;
                point1 = pointTmp;
            }
        }

        private static void Validate(ref double x)
        {
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Incorrect input.");
            }
        }
    }
}
