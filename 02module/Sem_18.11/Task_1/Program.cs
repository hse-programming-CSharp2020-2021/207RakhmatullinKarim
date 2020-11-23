using System;

namespace Task_1
{
    class A
    {
        public virtual void getA()
        {
            Console.WriteLine("A");
        }
    }
    class B : A
    {
        public override void getA()
        {
            Console.WriteLine("B");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A[] arr = new A[10];
            Random ran = new Random();
            for (int k = 0; k < arr.Length; k++)
                if (ran.Next(0, 3) % 2 == 0) arr[k] = new A();
                else arr[k] = new B();
            foreach (A d in arr) d.getA();
            Console.WriteLine("\nОбъекты класса B: ");
            foreach (A d in arr)
                if (d is B) d.getA();
            Console.WriteLine("\nОбъекты класса A: ");
            foreach (A d in arr)
                if (!(d is B)) d.getA();
            Console.WriteLine();

        }
    }
}
