using System;

namespace DoubleArr
{
    /*Определить класс Circle с полем радиус _r и свойством доступа к нему, 
     * значение радиуса положительное вещественное число. 
     * В классе Circle описать конструктор без параметров и конструктор с 
     * вещественным параметром. Определить свойство S – площадь круга 
     * заданного радиуса.
     * 
     * 
     * В основной программе получить от пользователя 
     * диапазон изменения значения радиуса: (Rmin, Rmax), Rmin, Rmax – 
     * произвольные вещественные числа и величину шага delta разбиения 
     * данного диапазона. Создать объект типа Circle, последовательно 
     * изменяя значение радиуса на delta вычислять и выводить на экран 
     * значение площади круга, ограниченного данной окружностью.
*/
    class Circle
    {
        private double _r;

        public double R
        {
            get
            {
                return _r;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Negative value");
                _r = value;
            }
        }

        public double C
        {
            get
            {
                return Math.PI * 2 * _r;
            }
        }

        public double S
        {
            get
            {
                return Math.PI * _r * _r;
            }
        }

        public Circle()
        {
            R = 1;
        }

        public Circle(double radius)
        {
            R = radius;
        }

        public override string ToString()
        {
            return $"Circle: radius = {_r}, square = {S}, length = {C}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double rmin = double.Parse(Console.ReadLine());
            double rmax = double.Parse(Console.ReadLine());
            double delta = double.Parse(Console.ReadLine());
            int cnt;
            Console.WriteLine("Input count of circles");
            int.TryParse(Console.ReadLine(), out cnt);
            Circle circle;
            Circle[] arrOfCircles = new Circle[cnt];
            Random rnd = new Random();
            for(int i = 0; i < cnt; i++)
            {
                circle = new Circle(rmin + rnd.NextDouble() * (rmax - rmin));
                arrOfCircles[i] = circle;
                Console.WriteLine(arrOfCircles[i].ToString());
            }

            Circle circleMaxSquare = new Circle();
            for (int i = 0; i < cnt; i++)
            {
                if(arrOfCircles[i].S > circleMaxSquare.S)
                {
                    circleMaxSquare = arrOfCircles[i];
                }
            }
            Console.WriteLine(circleMaxSquare.ToString());

        }
    }
}
