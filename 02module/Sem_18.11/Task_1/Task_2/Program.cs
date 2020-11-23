using System;

namespace Task_2
{
    class Point
    {
        double x;
        double y;
        public virtual double Area { get; set; }
        public virtual double Len { get; set; }
        public virtual void Display()
        {
            Console.WriteLine($"x = {x:f3}\ty = {y:f3}\tarea = {Area:f3}");
        }
    }
    class Circle : Point
    {
        double rad;
        double xC;
        double yC;
        public Circle(double rad, double x, double y)
        {
            this.rad = rad;
            xC = x;
            yC = y;
            
        }
        public double Rad
        {
            get
            {
                return rad;
            }
        }
        public override double Area
        {
            get
            {
                return Math.PI * rad * rad;
            }
        }
        public override double Len
        {
            get
            {
                return 2 * Math.PI * rad;
            }
        }
        public override void Display()
        {
            Console.WriteLine($"radius = {rad:f3}\tCenter coordinates = ({xC:f3}, {yC:f3})");
            Console.WriteLine($"area = {Area:f3}\tcircle length = {Len:f3}");
        }
    }
    class Square : Point
    {
        double side;
        double xC;
        double yC;
        public Square(double x, double y, double side)
        {
            xC = x;
            yC = y;
            this.side = side;
        }
        public double Side
        {
            get
            {
                return side;
            }
        }
        public override double Area
        {
            get
            {
                return side * side;
            }
        }
        public override double Len
        {
            get
            {
                return 4 * side;
            }
        }
        public override void Display()
        {
            Console.WriteLine($"side = {side:f3}\tCenter coordinates = ({xC:f3}, {yC:f3})");
            Console.WriteLine($"area = {Area:f3}\tperimetr = {Len:f3}");
        }
    }
    class Program
    {
        static Point[] FigArray()
        {
            Random rnd = new Random();
            int circlesCnt = rnd.Next(11);
            int squaresCnt = rnd.Next(11);
            Point[] arrOfFigures = new Point[circlesCnt + squaresCnt];
            for(int i = 0; i < circlesCnt; i++)
            {
                double rad = 10 + 90 * rnd.NextDouble();
                double xC = 10 + 90 * rnd.NextDouble();
                double yC = 10 + 90 * rnd.NextDouble();
                arrOfFigures[i] = new Circle(rad, xC, yC);
            }
            for(int i = circlesCnt; i < arrOfFigures.Length; i++)
            {
                double side = 10 + 90 * rnd.NextDouble();
                double xC = 10 + 90 * rnd.NextDouble();
                double yC = 10 + 90 * rnd.NextDouble();
                arrOfFigures[i] = new Square(xC, yC, side);
            }
            return arrOfFigures;
        }
        static void Main(string[] args)
        {
            Point p = new Point();
            p.Display();
            Console.WriteLine("p.Area для Point = " + p.Area);
            p = new Circle(1, 2, 6);
            p.Display();
            Console.WriteLine("p.Area для Circle = " + p.Area);
            p = new Square(3, 5, 8);
            p.Display();
            Console.WriteLine("p.Area для Square = " + p.Area);
            Point[] arr = FigArray();
            PrintArrProperties(arr);
            Array.Sort(arr, (x1, x2) => x1.Area.CompareTo(x2.Area));
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i].Display();
            }
        }

        private static void PrintArrProperties(Point[] arr)
        {
            int cntCircles = 0;
            double sumCirclesArea = 0;
            double sumSquaresArea = 0;
            double sumCirclesLen = 0;
            double sumSquaresLen = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Circle)
                {
                    cntCircles++;
                    sumCirclesArea += arr[i].Area;
                    sumCirclesLen += arr[i].Len;
                }
                else
                {
                    sumSquaresArea += arr[i].Area;
                    sumSquaresLen += arr[i].Len;
                }
            }
            Console.WriteLine($"Count of circles = {cntCircles}");
            Console.WriteLine($"Count of squares = {arr.Length - cntCircles}");
            Console.WriteLine($"Average area of circle = {sumCirclesArea / cntCircles:f3}");
            Console.WriteLine($"Average length of circle = {sumCirclesLen / cntCircles:f3}");
            Console.WriteLine($"Average area of square = {sumSquaresArea / (arr.Length - cntCircles):f3}");
            Console.WriteLine($"Average perimetr of square = {sumSquaresArea / (arr.Length - cntCircles):f3}");
        }
    }
}
