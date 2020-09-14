using System;

namespace Homework_2_06
{
    class Program
    {
        static void Main(string[] args)
        {
            double s, p;
            Console.WriteLine("Input ");
            if(!double.TryParse(Console.ReadLine(), out s) || s <= 0)
            {
                Console.WriteLine("Error");
                return;
            }
            if (!double.TryParse(Console.ReadLine(), out p) || p <= 0)
            {
                Console.WriteLine("Error");
                return;
            }
            
            Console.WriteLine("{0:C}", s * p / 100);


        }
    }
}
