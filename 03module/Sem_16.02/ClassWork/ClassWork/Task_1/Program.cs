using System;

namespace Task_1
{
    class Program
    {
        interface ICalculation
        {
            public double Perform(double number);
        }
        class Add : ICalculation
        {
            double sum;
            public Add(double sum)
            {
                this.sum = sum;
            }
            public double Perform(double number)
            {
                return number + sum;
            }
        }
        class Multiply : ICalculation
        {
            double mul;
            public Multiply(double mul)
            {
                this.mul = mul;
            }
            public double Perform(double number)
            {
                return number * mul;
            }
        }
        static double Calculate(double number, ICalculation op1, ICalculation op2)
        {
            return op2.Perform(op1.Perform(number));
        }
        static void Main(string[] args)
        {
            double n = 0;
            ICalculation op1 = new Add(5.7);
            ICalculation op2 = new Multiply(-100);
            Console.WriteLine(Calculate(n, op2, op1));
        }
    }
}
