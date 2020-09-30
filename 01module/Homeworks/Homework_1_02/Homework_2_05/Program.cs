using System;

namespace Homework_2_05
{
    class Program
    {
        static public double x, y, z;
        static public string str;
        static public void My()
        {
            str = ((x + y) > z) && ((x + z) > y) && ((y + z) > x) ? "Yes" : "No";
            Console.WriteLine(str);


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 lenghts ");
            if(!double.TryParse(Console.ReadLine(), out x) || x <= 0)
            {
                Console.WriteLine("Error");
                return;
            }
            if (!double.TryParse(Console.ReadLine(), out y) || y <= 0)
            {
                Console.WriteLine("Error");
                return;
            }
            if (!double.TryParse(Console.ReadLine(), out z) || z <= 0)
            {
                Console.WriteLine("Error");
                return;
            }
            My();


        }
    }
}