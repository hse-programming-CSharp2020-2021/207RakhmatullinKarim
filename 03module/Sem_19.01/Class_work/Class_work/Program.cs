using System;

namespace Class_work
{
    class Plant
    {
        double growth;
        double photosensitivity;
        double frostresinstance;
        public Plant(double g, double p, double f)
        {
            growth = g;
            photosensitivity = p;
            frostresinstance = f;
        }
        public double Growth
        {
            get
            {
                return growth;
            }
        }
        public double Photo
        {
            get
            {
                return photosensitivity;
            }
        }
        public double Frost
        {
            get
            {
                return frostresinstance;
            }
        }
        public override string ToString()
        {
            return $"Growth: {growth:f3}\tPhotosensitivity{photosensitivity:f3}\tFrostresinstance:{frostresinstance:f3}";
        }
    }
    class Program
    {
        static readonly Random rnd = new Random();
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Input amount of plants:");
            } while ((!int.TryParse(Console.ReadLine(), out n)) || (n <= 0));
            Plant[] arr = new Plant[n];
            //for(int i = 0; i < n; i++)
            //{
            //    arr[i] = new Plant(0, 0, 0);
            //}
            for (int i = 0; i < n; i++)
            {
                arr[i] = new Plant(25 + rnd.NextDouble() * 75, rnd.NextDouble() * 100, rnd.NextDouble() * 80);
            }
            Array.ForEach(arr, (el) => Console.WriteLine(el));
            Array.Sort(arr, (a, b) =>
            {
                if (a.Growth > b.Growth)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            });
            Array.ForEach(arr, (el) => Console.WriteLine(el));
            Array.Sort(arr, (a, b) => a.Frost > b.Frost ? 1 : -1);
            Array.ForEach(arr, (el) => Console.WriteLine(el));
        }
    }
}
