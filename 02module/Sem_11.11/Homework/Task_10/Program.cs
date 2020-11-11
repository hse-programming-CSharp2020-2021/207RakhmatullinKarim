using System;
using System.Collections.Generic;

namespace Task_10
{
    class Circle
    {
        double x;
        double y;
        double r;
        public Circle(double x, double y, double r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }
        public bool doesIntersect(Circle circle)
        {
            double dest = Math.Sqrt((x - circle.x) * (x - circle.x) + (y - circle.y) * (y - circle.y));
            if(dest <= r + circle.r)
            {
                return true;
            }
            return false;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"x = {x:f2} y = {y:f2} r = {r:f2}");
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
                Console.WriteLine("Input amount of circles.");
                int n = ValidateAmount();
                Circle[] arrOfCircles = new Circle[n];
                GenerateArrOfCircles(arrOfCircles);
                Circle circle1 = new Circle(1 + rnd.NextDouble() * 14, 1 + rnd.NextDouble() * 14, 1 + rnd.NextDouble() * 14);
                Console.Write("New circle: ");
                circle1.ShowInfo();
                Console.WriteLine();
                for (int i = 0; i < arrOfCircles.Length; i++)
                {
                    if (arrOfCircles[i].doesIntersect(circle1))
                    {
                        arrOfCircles[i].ShowInfo();
                    }
                }
                Console.WriteLine("Press 'Escape' to exit.");
                keyToExit = Console.ReadKey();
            } while (keyToExit.Key != ConsoleKey.Escape);

        }

        private static void GenerateArrOfCircles(Circle[] arrOfCircles)
        {
            Random rnd = new Random();
            for (int i = 0; i < arrOfCircles.Length; i++)
            {
                arrOfCircles[i] = new Circle(1 + rnd.NextDouble() * 14, 1 + rnd.NextDouble() * 14, 1 + rnd.NextDouble() * 14);
                arrOfCircles[i].ShowInfo();
            }
            Console.WriteLine();
        }

        private static int ValidateAmount()
        {
            int n;
            while ((!int.TryParse(Console.ReadLine(), out n)) || (n < 1))
            {
                Console.WriteLine("Incorrect input! Try again.");
            }

            return n;
        }
    }
}
