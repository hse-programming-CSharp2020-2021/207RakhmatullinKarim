using System;

namespace Task_3
{
    public class TemperatureConvertImp
    {
        public double FToC(double deg)
        {
            return ((double)(5) / 9) * (deg - 32);
        }
        public double CToF(double deg)
        {
            Console.WriteLine("Fahrenheit");
            return ((double)(9) / 5) * deg + 32;
        }
    }
    public static class StaticTempConverters
    {
        public static double CToK(double deg)
        {
            Console.WriteLine("Kelvin");
            return deg + 273.15;
        }
        public static double KToC(double deg)
        {
            return deg - 273.15;
        }
        public static double CToRan(double deg)
        {
            Console.WriteLine("Rankin");
            return CToK(deg) * 9 / 5;
        }
        public static double RanToC(double deg)
        {
            return (deg - 491.67) * 5 / 9;
        }
        public static double CToRem(double deg)
        {
            Console.WriteLine("Remer");
            return deg * 4 / 5;
        }
        public static double RemToC(double deg)
        {
            return deg * 5 / 4;
        }

    }
    class Program
    {
        delegate double delegateConvertTemperature(double num);
        static void Main(string[] args)
        {
            TemperatureConvertImp convert = new TemperatureConvertImp();
            delegateConvertTemperature[] delArr = { convert.CToF, StaticTempConverters.CToK, StaticTempConverters.CToRan, StaticTempConverters.CToRem };
            double input;
            do
            {
                Console.WriteLine("Input degrees in Celsium: ");
            }while (!double.TryParse(Console.ReadLine(), out input));
            foreach(delegateConvertTemperature del in delArr)
            {
                Console.WriteLine($"{del(input):f3}");
            }

        }
    }
}
