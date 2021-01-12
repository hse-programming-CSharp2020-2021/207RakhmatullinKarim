using System;

namespace Task_4
{
    class Robot
    {
        // класс для представления робота
        int x = 0,
            y = 0; // положение робота на плоскости

        int downSize, rightSize;
        public Robot(int y, int x)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
            WriteAt("*");
            downSize = y;
            rightSize = x;
        }
        public void Right()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            WriteAt("+");
            x++;
            if (x > rightSize)
            {
                throw new IndexOutOfRangeException("Robot is out of the border!");
            }
            Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
            WriteAt("*");
        }      // направо
        public void Left()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            WriteAt("+");
            x--;
            if (x < 0)
            {
                throw new IndexOutOfRangeException("Robot is out of the border!");
            }
            Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
            WriteAt("*");
        }      // налево
        public void Forward()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            WriteAt("+");
            y++;
            if (y > downSize)
            {
                throw new IndexOutOfRangeException("Robot is out of the border!");
            }
            Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
            WriteAt("*");
        }  // вперед
        public void Backward()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            WriteAt("+");
            y--;
            if (y < 0)
            {
                throw new IndexOutOfRangeException("Robot is out of the border!");
            }
            Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
            WriteAt("*");
        }  // назад
        public void WriteAt(string s)
        {

            try
            {
                Console.SetCursorPosition(x, y);
                Console.Write(s);
                Console.ResetColor();
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
        public string Position()
        {  // сообщить координаты
            return String.Format("The Robot position: x={0}, y={1}", x, y);
        }
    }

    class Program
    {
        delegate void Steps(); // делегат-тип

        static void Main(string[] args)
        {
            int rightSize, downSize;
            do
            {
                Console.WriteLine("Input right border:");
            } while ((!int.TryParse(Console.ReadLine(), out rightSize)) || (rightSize <= 0));
            do
            {
                Console.WriteLine("Input down border:");
            } while ((!int.TryParse(Console.ReadLine(), out downSize)) || (downSize <= 0));
            Console.WriteLine("Input line of commands:");
            string s = Console.ReadLine();
            Robot rob = new Robot(downSize, rightSize);    // конкретный робот 
            Steps[] trace = new Steps[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'R':
                        trace[i] = rob.Right;
                        break;
                    case 'L':
                        trace[i] = rob.Left;
                        break;
                    case 'F':
                        trace[i] = rob.Forward;
                        break;
                    case 'B':
                        trace[i] = rob.Backward;
                        break;
                    default:
                        Console.WriteLine("Incorrect input!");
                        break;
                }
            }
            for (int i = 0; i < trace.Length; i++)
            {
                try
                {
                    trace[i]();
                }
                catch(IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadKey();

        }
    }
}
