using System;

namespace Task_4
{
    struct Rectangle : IComparable
    {
        int a, b;
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Square
        {
            get => a * b;
        }
        public int CompareTo(object obj)
        {
            if (Square < ((Rectangle)obj).Square)
                return -1;
            else if (Square > ((Rectangle)obj).Square)
                return 1;
            else
                return 0;
        }
    }
    class Block3D : IComparable
    {
        Rectangle osn;
        int height;
        public Block3D(Rectangle osn, int height)
        {
            this.osn = osn;
            this.height = height;
        }

        public int CompareTo(object obj)
        {
            if (osn.Square < ((Block3D)obj).osn.Square)
                return -1;
            else if (osn.Square > ((Block3D)obj).osn.Square)
                return 1;
            else
                return 0;
        }
        public override string ToString()
        {
            return $"Height: {height}  Area: {osn.Square}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Block3D[] arr = new Block3D[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = new Block3D(new Rectangle(rnd.Next(1, 10), rnd.Next(1, 10)), rnd.Next(1, 10));
            }
            PrintArr(arr);
            Array.Sort(arr);
            Console.WriteLine();
            PrintArr(arr);
        }

        private static void PrintArr(Block3D[] arr)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
