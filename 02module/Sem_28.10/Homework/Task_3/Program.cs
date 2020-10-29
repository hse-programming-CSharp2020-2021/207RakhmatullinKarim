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
                return $"radius = {vpisRad:f3}; count of sides = {sidesCount}; Perimetr = {Perimetr:f3}";
                
            }

        }
        static void Main(string[] args)
        {
            int cnt = ValidateCountOFSides();
            double rad = ValidateRadius();
            RegPolygon polygon = new RegPolygon(cnt, rad);
            Console.Write(polygon.PolygonData());
            Console.WriteLine($" S = {polygon.S:f3}");
            int n = ValidateCountOfPolygons();
            RegPolygon[] arrOfPolygons = new RegPolygon[n];
            FillArr(n, arrOfPolygons);
            int indexOfMax, indexOfMin;
            indexOfMax = indexOfMin = -1;
            FindIndexMaxAndMin(arrOfPolygons, ref indexOfMax, ref indexOfMin);
            Output(arrOfPolygons, indexOfMax, indexOfMin);

        }

        private static void Output(RegPolygon[] arrOfPolygons, int indexOfMax, int indexOfMin)
        {
            for (int i = 0; i < arrOfPolygons.Length; i++)
            {
                if (i == indexOfMax)
                {
                    Console.Write(arrOfPolygons[i].PolygonData());
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" S = {arrOfPolygons[i].S:f3}");
                    Console.ResetColor();

                }
                else if (i == indexOfMin)
                {
                    Console.Write(arrOfPolygons[i].PolygonData());
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($" S = {arrOfPolygons[i].S:f3}");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(arrOfPolygons[i].PolygonData());
                    Console.WriteLine($" S = {arrOfPolygons[i].S:f3}");
                }
            }
        }

        private static void FindIndexMaxAndMin(RegPolygon[] arrOfPolygons, ref int indexOfMax, ref int indexOfMin)
        {
            double maxS = 0, minS = double.MaxValue;
            indexOfMax = indexOfMin = -1;
            for (int i = 0; i < arrOfPolygons.Length; i++)
            {
                if (arrOfPolygons[i].S > maxS)
                {
                    maxS = arrOfPolygons[i].S;
                    indexOfMax = i;
                }
                if (arrOfPolygons[i].S < minS)
                {
                    minS = arrOfPolygons[i].S;
                    indexOfMin = i;
                }
            }
        }

        private static void FillArr(int n, RegPolygon[] arrOfPolygons)
        {
            for (int i = 0; i < n; i++)
            {
                int cntArr = ValidateCountOFSides();
                double radArr = ValidateRadius();
                arrOfPolygons[i] = new RegPolygon(cntArr, radArr);
                Console.Write(arrOfPolygons[i].PolygonData());
                Console.WriteLine($" S = {arrOfPolygons[i].S:f3}");
            }
        }

        private static int ValidateCountOfPolygons()
        {
            int n;
            Console.WriteLine("Input the count of polygons");
            while ((!int.TryParse(Console.ReadLine(), out n)) || (n <= 0))
            {
                Console.WriteLine("Incorrect input");
            }
            return n;
        }

        private static double ValidateRadius()
        {
            double rad;
            Console.WriteLine("Input radius");
            while ((!double.TryParse(Console.ReadLine(), out rad)) || (rad <= 0))
            {
                Console.WriteLine("Incorrect input.");
            }

            return rad;
        }

        private static int ValidateCountOFSides()
        {
            int cnt;
            Console.WriteLine("INput count of sides.");
            while ((!int.TryParse(Console.ReadLine(), out cnt)) || (cnt <= 2))
            {
                Console.WriteLine("Incorrect input.");
            }

            return cnt;
        }
    }
}
