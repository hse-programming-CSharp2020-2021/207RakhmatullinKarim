using System;

namespace Task_3
{
    class Program
    {
        class RegPolygon
        {
            int sidesCount;
            double vpisRad;
            public RegPolygon(int cnt = 3, double rad = 1)
            {
                sidesCount = cnt;
                vpisRad = rad;
            }
            public double Perimetr
            {
                get
                {
                    double tmp = Math.Tan(Math.PI / sidesCount);
                    return 2 * tmp * sidesCount * vpisRad;
                }
            }
            public double S
            {
                get
                {
                    return Perimetr * vpisRad / 2;
                }
            }
            public string PolygonData()
            {
                return $"radius = {vpisRad:f3}; count of sides = {sidesCount}; Perimetr = {Perimetr:f3}; S = {S:f3}";
                
            }

        }
        static void Main(string[] args)
        {
            int cnt;
            double rad;
            Console.WriteLine("INput count of sides.");
            while((!int.TryParse(Console.ReadLine(), out cnt)) || (cnt <= 2))
            {
                Console.WriteLine("Incorrect input.");
            }
            Console.WriteLine("Input radius");
            while ((!double.TryParse(Console.ReadLine(), out rad)) || (rad <= 0))
            {
                Console.WriteLine("Incorrect input.");
            }
            RegPolygon polygon = new RegPolygon(cnt, rad);
            Console.WriteLine(polygon.PolygonData());
        }
    }
}
